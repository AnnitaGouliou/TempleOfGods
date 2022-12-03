using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arescoliision : MonoBehaviour
{
    [SerializeField] GameObject templeofares;
[SerializeField] GameObject arescorrect;
[SerializeField] GameObject arescorrect1;
[SerializeField] GameObject areswrong;



   


   void OnTriggerEnter(Collider col)

   {
       if(col.gameObject.name == "ares")
       {
           Debug.Log("Detected");
           Destroy (col.gameObject);

           arescorrect.SetActive(true);
           arescorrect1.SetActive(true);
           
       }

       else if(col.gameObject.name == "sandals" || col.gameObject.name == "rose" || col.gameObject.name == "crown" || col.gameObject.name == "olive wearth" || col.gameObject.name == "wheat"  || col.gameObject.name == "grapes"  || col.gameObject.name == "harp" || col.gameObject.name == "bowandarrow" || col.gameObject.name == "trident" || col.gameObject.name == "hammer" || col.gameObject.name == "lightning strike") 
       {
           StartCoroutine(ShowForSec());
 
       }

   }
private void showwrong()
{
    areswrong.SetActive(true);

    areswrong.SetActive(false);
} 

 private IEnumerator ShowForSec()
{

   areswrong.SetActive(true);
    yield return new WaitForSeconds(4);
    areswrong.SetActive(false);
}
}
