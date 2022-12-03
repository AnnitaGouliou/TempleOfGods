using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class demetercollision : MonoBehaviour
{
     [SerializeField] GameObject templeofdemeter;
[SerializeField] GameObject demetercorrect;
[SerializeField] GameObject demetercorrect1;
[SerializeField] GameObject demeterwrong;



   


   void OnTriggerEnter(Collider col)

   {
       if(col.gameObject.name == "wheat")
       {
           Debug.Log("Detected");
           Destroy (col.gameObject);

           demetercorrect.SetActive(true);
           demetercorrect1.SetActive(true);
           
       }

       else if(col.gameObject.name == "sandals" || col.gameObject.name == "rose" || col.gameObject.name == "crown" || col.gameObject.name == "olive wearth" || col.gameObject.name == "bowandarrow"  || col.gameObject.name == "grapes"  || col.gameObject.name == "harp" || col.gameObject.name == "ares" || col.gameObject.name == "trident" || col.gameObject.name == "hammer" || col.gameObject.name == "lightning strike") 
       {
           StartCoroutine(ShowForSec());
 
       }

   }
private void showwrong()
{
    demeterwrong.SetActive(true);

    demeterwrong.SetActive(false);
} 

 private IEnumerator ShowForSec()
{

   demeterwrong.SetActive(true);
    yield return new WaitForSeconds(4);
    demeterwrong.SetActive(false);
}
}
