using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aphroditecollision : MonoBehaviour
{
   [SerializeField] GameObject templeofaphrodite;
[SerializeField] GameObject aphroditecorrect;
[SerializeField] GameObject aphroditecorrect1;
[SerializeField] GameObject aphroditewrong;



   


   void OnTriggerEnter(Collider col)

   {
       if(col.gameObject.name == "rose")
       {
           Debug.Log("Detected");
           Destroy (col.gameObject);

           aphroditecorrect.SetActive(true);
           aphroditecorrect1.SetActive(true);
           
       }

       else if(col.gameObject.name == "sandals" || col.gameObject.name == "crown" || col.gameObject.name == "lightning strike" || col.gameObject.name == "bowandarrow" || col.gameObject.name == "wheat"  || col.gameObject.name == "grapes"  || col.gameObject.name == "harp" || col.gameObject.name == "ares" || col.gameObject.name == "trident" || col.gameObject.name == "hammer" || col.gameObject.name == "olive wearth") 
       {
           StartCoroutine(ShowForSec());
 
       }

   }
private void showwrong()
{
    aphroditewrong.SetActive(true);

    aphroditewrong.SetActive(false);
} 

 private IEnumerator ShowForSec()
{

   aphroditewrong.SetActive(true);
    yield return new WaitForSeconds(4);
    aphroditewrong.SetActive(false);
}
}
