using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dionysuscollision : MonoBehaviour
{
       
[SerializeField] GameObject templeofdionysus;
[SerializeField] GameObject dionysuscorrect;
[SerializeField] GameObject dionysuscorrect1;
[SerializeField] GameObject dionysuswrong;



   


   void OnTriggerEnter(Collider col)

   {
       if(col.gameObject.name == "grapes")
       {
           Debug.Log("Detected");
           Destroy (col.gameObject);

           dionysuscorrect.SetActive(true);
           dionysuscorrect1.SetActive(true);
           
       }

       else if(col.gameObject.name == "sandals" || col.gameObject.name == "rose" || col.gameObject.name == "crown" || col.gameObject.name == "olive wearth" || col.gameObject.name == "wheat"  || col.gameObject.name == "hammer"  || col.gameObject.name == "harp" || col.gameObject.name == "bowandarrow" || col.gameObject.name == "ares" || col.gameObject.name == "trident" || col.gameObject.name == "lightning strike") 
       {
           StartCoroutine(ShowForSec());
 
       }

   }
private void showwrong()
{
    dionysuswrong.SetActive(true);

    dionysuswrong.SetActive(false);
} 

 private IEnumerator ShowForSec()
{

    dionysuswrong.SetActive(true);
    yield return new WaitForSeconds(4);
    dionysuswrong.SetActive(false);
}
}
