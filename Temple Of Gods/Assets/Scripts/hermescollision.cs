using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grapecollision : MonoBehaviour
{
   


   void OnCollisionEnter(Collision col)
   {
       if(col.gameObject.name == "grapes")
       {
         //  Debug.Log("Detected");
           Destroy (col.gameObject);
       }
   }


   void OnTriggerEnter(Collider col)

   {
       if(col.gameObject.name == "grapes")
       {
           Debug.Log("Detected");
           Destroy (col.gameObject);
       }
   }
}
