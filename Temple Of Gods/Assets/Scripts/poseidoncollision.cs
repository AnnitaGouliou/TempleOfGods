using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class poseidoncollision : MonoBehaviour
{
[SerializeField] GameObject templeofposeidon;
[SerializeField] GameObject poseidoncorrect;
[SerializeField] GameObject poseidoncorrect1;
[SerializeField] GameObject poseidonwrong;



   


   void OnTriggerEnter(Collider col)

   {
       if(col.gameObject.name == "trident")
       {
           Debug.Log("Detected");
           Destroy (col.gameObject);

           poseidoncorrect.SetActive(true);
           poseidoncorrect1.SetActive(true);
           
       }

       else if(col.gameObject.name == "sandals" || col.gameObject.name == "rose" || col.gameObject.name == "crown" || col.gameObject.name == "olive wearth" || col.gameObject.name == "wheat"  || col.gameObject.name == "grapes"  || col.gameObject.name == "harp" || col.gameObject.name == "bowandarrow" || col.gameObject.name == "ares" || col.gameObject.name == "hammer" || col.gameObject.name == "lightning strike") 
       {
           StartCoroutine(ShowForSec());
 
       }

   }
private void showwrong()
{
    poseidonwrong.SetActive(true);

    poseidonwrong.SetActive(false);
} 

 private IEnumerator ShowForSec()
{

   poseidonwrong.SetActive(true);
    yield return new WaitForSeconds(4);
    poseidonwrong.SetActive(false);
}
}
