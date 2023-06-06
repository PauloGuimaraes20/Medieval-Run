using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Collectables : MapInteractions
{
    private int rotateSpeed = 1; 
    
    


    void Update()
    {  
    }

    public void RotateColl()
    {
        transform.Rotate(0, rotateSpeed, 0   ); //Space.World

    }

     
    



}
