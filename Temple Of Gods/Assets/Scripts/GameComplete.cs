using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameComplete : MonoBehaviour
{

   public GameObject hermescorrect;
   public GameObject hephaestuscorrect;
   public GameObject poseidoncorrect;
   public GameObject arescorrect;
   public GameObject dionysuscorrect;
   public GameObject athenacorrect;
   public GameObject zeuscorrect;
   public GameObject heracorrect;
   public GameObject demetercorrect;
   public GameObject aphroditecorrect;
   public GameObject artemiscorrect;
   public GameObject apollocorrect;


    // Start is called before the first frame update
     //public 
     //checkItem
     void Update ()
    {
        
        if (hermescorrect.active == true && hephaestuscorrect.active == true && poseidoncorrect.active == true && arescorrect.active == true && dionysuscorrect.active == true  && athenacorrect.active == true && zeuscorrect.active == true && heracorrect.active == true && demetercorrect.active == true && artemiscorrect.active == true && aphroditecorrect.active == true && apollocorrect.active == true)
        {
            Debug.Log("QUIT GAME");
    
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   
        }
    }   
    
}
