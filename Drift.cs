using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drift : MonoBehaviour
{
     private bool moveForward = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

         if (moveForward)
            transform.Translate((Vector3.forward * Time.deltaTime * Random.Range(0,10f))/4);
         else
            transform.Translate((Vector3.back * Time.deltaTime * Random.Range(0,10f))/4);
         
         if(transform.position.x >= 250f) {
             moveForward = false;
         }
         
         if(transform.position.x <= -50f) {
             moveForward = true;
         }

   
       


    }
}
