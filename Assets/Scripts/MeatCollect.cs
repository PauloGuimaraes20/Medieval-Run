using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeatCollect : Collectables
{
    public AudioSource MeatFX;
    UIDirector UIDirector = new UIDirector();
    // Update is called once per frame
    void Update()
    {
        RotateColl();
    }


    void OnTriggerEnter(Collider other)
    {
        MeatFX.Play();
        this.gameObject.SetActive(false);
        UIDirector.increasePointCount();
        Debug.Log($"A pontuação atual é de {UIDirector.getPointCount()} pontos");

    }




}
