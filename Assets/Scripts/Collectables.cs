using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectables : MonoBehaviour
{
    private int rotateSpeed = 1; //REVISAR ESTA PARTE
    public AudioSource MeatFX;
    private static int pointCount = 0; 
    public GameObject pointCountDisplay;


    // Update is called once per frame
    void Update()
    {
        RotateColl();
        pointCountDisplay.GetComponent<Text>().text = "" + pointCount;
    }

    private void RotateColl()
    {
        transform.Rotate(0, rotateSpeed, 0   ); //Space.World

    }

     
    void OnTriggerEnter(Collider other) 
    {
        MeatFX.Play();
        this.gameObject.SetActive(false);
        pointCount++;
        Debug.Log($"A pontuação atual é de {pointCount} pontos");

    }



}
