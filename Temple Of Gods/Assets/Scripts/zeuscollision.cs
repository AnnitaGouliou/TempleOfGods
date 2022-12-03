using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zeuscollision : MonoBehaviour
{
      [SerializeField] GameObject templeofzeus;
[SerializeField] GameObject zeuscorrect;
[SerializeField] GameObject zeuscorrect1;
[SerializeField] GameObject zeuswrong;



   


   void OnTriggerEnter(Collider col)

   {
       if(col.gameObject.name == "lightning strike")
       {
           Debug.Log("Detected");
           Destroy (col.gameObject);

           zeuscorrect.SetActive(true);
           zeuscorrect1.SetActive(true);
           
       }

       else if(col.gameObject.name == "sandals" || col.gameObject.name == "rose" || col.gameObject.name == "crown" || col.gameObject.name == "bowandarrow" || col.gameObject.name == "wheat"  || col.gameObject.name == "grapes"  || col.gameObject.name == "harp" || col.gameObject.name == "ares" || col.gameObject.name == "trident" || col.gameObject.name == "hammer" || col.gameObject.name == "olive wearth") 
       {
           StartCoroutine(ShowForSec());
 
       }

   }
private void showwrong()
{
    zeuswrong.SetActive(true);

    zeuswrong.SetActive(false);
} 

 private IEnumerator ShowForSec()
{

   zeuswrong.SetActive(true);
    yield return new WaitForSeconds(4);
    zeuswrong.SetActive(false);
}
}
