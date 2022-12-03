using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hermescollision : MonoBehaviour
{
   
[SerializeField] GameObject templeofhermes;
[SerializeField] GameObject hermescorrect;
[SerializeField] GameObject hermescorrect1;
[SerializeField] GameObject hermeswrong;



   //void OnCollisionEnter(Collision col)
   //{
   //    if(col.gameObject.name == "sandals")
   //    {
         //  Debug.Log("Detected");
    //       Destroy (col.gameObject);
     //  }
//
    //   else (col.gameObject.name == "grapes")
      // {
     //      grapes
    //   }
  // }


   void OnTriggerEnter(Collider col)

   {
       if(col.gameObject.name == "sandals")
       {
           Debug.Log("Detected");
           Destroy (col.gameObject);

           hermescorrect.SetActive(true);
           hermescorrect1.SetActive(true);
           
       }

       else if(col.gameObject.name == "grapes" || col.gameObject.name == "rose" || col.gameObject.name == "crown" || col.gameObject.name == "olive wearth" || col.gameObject.name == "wheat"  || col.gameObject.name == "hammer"  || col.gameObject.name == "harp" || col.gameObject.name == "bowandarrow" || col.gameObject.name == "ares" || col.gameObject.name == "trident" || col.gameObject.name == "lightning strike") 
       {
           StartCoroutine(ShowForSec());
 
       }

   }
private void showwrong()
{
    hermeswrong.SetActive(true);

    hermeswrong.SetActive(false);
} 

 private IEnumerator ShowForSec()
{

    hermeswrong.SetActive(true);
    yield return new WaitForSeconds(4);
    hermeswrong.SetActive(false);
}
   
}
