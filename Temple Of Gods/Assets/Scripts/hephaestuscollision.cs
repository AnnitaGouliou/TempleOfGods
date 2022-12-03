using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hephaestuscollision : MonoBehaviour
{
    [SerializeField] GameObject templeofhephaestus;
[SerializeField] GameObject hephaestuscorrect;
[SerializeField] GameObject hephaestuscorrect1;
[SerializeField] GameObject hephaestuswrong;



   


   void OnTriggerEnter(Collider col)

   {
       if(col.gameObject.name == "hammer")
       {
           Debug.Log("Detected");
           Destroy (col.gameObject);

           hephaestuscorrect.SetActive(true);
           hephaestuscorrect1.SetActive(true);
           
       }

       else if(col.gameObject.name == "sandals" || col.gameObject.name == "rose" || col.gameObject.name == "crown" || col.gameObject.name == "olive wearth" || col.gameObject.name == "wheat"  || col.gameObject.name == "grapes"  || col.gameObject.name == "harp" || col.gameObject.name == "bowandarrow" || col.gameObject.name == "ares" || col.gameObject.name == "trident" || col.gameObject.name == "lightning strike") 
       {
           StartCoroutine(ShowForSec());
 
       }

   }
private void showwrong()
{
    hephaestuswrong.SetActive(true);

    hephaestuswrong.SetActive(false);
} 

 private IEnumerator ShowForSec()
{

   hephaestuswrong.SetActive(true);
    yield return new WaitForSeconds(4);
    hephaestuswrong.SetActive(false);
}
}
