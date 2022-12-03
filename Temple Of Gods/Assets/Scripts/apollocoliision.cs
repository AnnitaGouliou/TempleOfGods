using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class apollocoliision : MonoBehaviour
{
     [SerializeField] GameObject templeofapollo;
[SerializeField] GameObject apollocorrect;
[SerializeField] GameObject apollocorrect1;
[SerializeField] GameObject apollowrong;



   


   void OnTriggerEnter(Collider col)

   {
       if(col.gameObject.name == "harp")
       {
           Debug.Log("Detected");
           Destroy (col.gameObject);

           apollocorrect.SetActive(true);
           apollocorrect1.SetActive(true);
           
       }

       else if(col.gameObject.name == "sandals" || col.gameObject.name == "crown" || col.gameObject.name == "lightning strike" || col.gameObject.name == "rose" || col.gameObject.name == "wheat"  || col.gameObject.name == "grapes"  || col.gameObject.name == "bowandarrow" || col.gameObject.name == "ares" || col.gameObject.name == "trident" || col.gameObject.name == "hammer" || col.gameObject.name == "olive wearth") 
       {
           StartCoroutine(ShowForSec());
 
       }

   }
private void showwrong()
{
    apollowrong.SetActive(true);

    apollowrong.SetActive(false);
} 

 private IEnumerator ShowForSec()
{

   apollowrong.SetActive(true);
    yield return new WaitForSeconds(4);
    apollowrong.SetActive(false);
}
}
