using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class artemiscollision : MonoBehaviour
{
    [SerializeField] GameObject templeofartemis;
[SerializeField] GameObject artemiscorrect;
[SerializeField] GameObject artemiscorrect1;
[SerializeField] GameObject artemiswrong;



   


   void OnTriggerEnter(Collider col)

   {
       if(col.gameObject.name == "bowandarrow")
       {
           Debug.Log("Detected");
           Destroy (col.gameObject);

           artemiscorrect.SetActive(true);
           artemiscorrect1.SetActive(true);
           
       }

       else if(col.gameObject.name == "sandals" || col.gameObject.name == "crown" || col.gameObject.name == "lightning strike" || col.gameObject.name == "rose" || col.gameObject.name == "wheat"  || col.gameObject.name == "grapes"  || col.gameObject.name == "harp" || col.gameObject.name == "ares" || col.gameObject.name == "trident" || col.gameObject.name == "hammer" || col.gameObject.name == "olive wearth") 
       {
           StartCoroutine(ShowForSec());
 
       }

   }
private void showwrong()
{
    artemiswrong.SetActive(true);

    artemiswrong.SetActive(false);
} 

 private IEnumerator ShowForSec()
{

   artemiswrong.SetActive(true);
    yield return new WaitForSeconds(4);
    artemiswrong.SetActive(false);
}
}
