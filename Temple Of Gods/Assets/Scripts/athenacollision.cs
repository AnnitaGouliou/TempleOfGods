using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class athenacollision : MonoBehaviour
{
       [SerializeField] GameObject templeofathena;
[SerializeField] GameObject athenacorrect;
[SerializeField] GameObject athenacorrect1;
[SerializeField] GameObject athenawrong;



   


   void OnTriggerEnter(Collider col)

   {
       if(col.gameObject.name == "olive wearth")
       {
           Debug.Log("Detected");
           Destroy (col.gameObject);

           athenacorrect.SetActive(true);
           athenacorrect1.SetActive(true);
           
       }

       else if(col.gameObject.name == "sandals" || col.gameObject.name == "rose" || col.gameObject.name == "crown" || col.gameObject.name == "bowandarrow" || col.gameObject.name == "wheat"  || col.gameObject.name == "grapes"  || col.gameObject.name == "harp" || col.gameObject.name == "ares" || col.gameObject.name == "trident" || col.gameObject.name == "hammer" || col.gameObject.name == "lightning strike") 
       {
           StartCoroutine(ShowForSec());
 
       }

   }
private void showwrong()
{
    athenawrong.SetActive(true);

    athenawrong.SetActive(false);
} 

 private IEnumerator ShowForSec()
{

   athenawrong.SetActive(true);
    yield return new WaitForSeconds(4);
    athenawrong.SetActive(false);
}
}
