using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public GameObject invTab;

    //use this for initialization
    void Start()
    {
        invTab.SetActive(false);
    }
    //update is called once per frame

    void Update ()
    {
        if (Input.GetKey(KeyCode.Tab))
            {
                invTab.SetActive(true);
                Cursor.visible = true;



            }
            else
            {
                invTab.SetActive(false);
                
            }
    }



}
