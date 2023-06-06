using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIDirector : MonoBehaviour
{
   
    public GameObject pointCountDisplay;
    private static int pointCount = 0;
    
    public int getPointCount() 
    {
        return pointCount;
    }

    public void increasePointCount() 
    {
        pointCount++;
    }



void Update()
    {
        pointCountDisplay.GetComponent<Text>().text = "" + getPointCount();
    }


}
