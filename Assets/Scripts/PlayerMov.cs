using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMov : Player
{
    private int moveSpeed = 3;
    public float leftRightSpeed = 4;
    public GameObject distCount;
    private int distRun;
    private bool addDist = false;
    private float distDelay = 1f;

    void Update()
    {
        FrontMov();
        SideMovKbrd();
        if (addDist == false)
        {
            addDist = true;
            StartCoroutine(AddingDist());
        }
    }


    IEnumerator AddingDist() 
    {
        distRun++;
        distCount.GetComponent<Text>().text = "" + distRun;
        yield return new WaitForSeconds(distDelay);
        addDist = false;

    }

    private void SideMovKbrd()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) 
        {
            if (this.gameObject.transform.position.x > LevelBoundary.leftSide) 
            {
                transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed);
            }
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            if (this.gameObject.transform.position.x < LevelBoundary.rightSide)
            {
                transform.Translate(Vector3.right * Time.deltaTime * leftRightSpeed);
               
            }
        }

    }


    private void FrontMov()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed /*, Space.world*/);

    }

}
