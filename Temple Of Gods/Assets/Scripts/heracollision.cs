using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heracollision : MonoBehaviour
{
   [SerializeField] GameObject templeofhera;
[SerializeField] GameObject heracorrect;
[SerializeField] GameObject heracorrect1;
[SerializeField] GameObject herawrong;



   


   void OnTriggerEnter(Collider col)

   {
       if(col.gameObject.name == "crown")
       {
           Debug.Log("Detected");
           Destroy (col.gameObject);

           heracorrect.SetActive(true);
           heracorrect1.SetActive(true);
           
       }

       else if(col.gameObject.name == "sandals" || col.gameObject.name == "rose" || col.gameObject.name == "lightning strike" || col.gameObject.name == "bowandarrow" || col.gameObject.name == "wheat"  || col.gameObject.name == "grapes"  || col.gameObject.name == "harp" || col.gameObject.name == "ares" || col.gameObject.name == "trident" || col.gameObject.name == "hammer" || col.gameObject.name == "olive wearth") 
       {
           StartCoroutine(ShowForSec());
 
       }

   }
private void showwrong()
{
    herawrong.SetActive(true);

    herawrong.SetActive(false);
} 

 private IEnumerator ShowForSec()
{

   herawrong.SetActive(true);
    yield return new WaitForSeconds(4);
    herawrong.SetActive(false);
}
}
