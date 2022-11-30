using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UseInventory : MonoBehaviour
{
    

public bool item;
public Transform theDest;

GameObject inv;
GameObject player;


void Start()
    {
    inv = GameObject.FindWithTag("GameController");
    player = GameObject.FindWithTag("Player");
    }


  public void UseItem()
    {

        if (item)
         {
         void OnMouseDown()
{
    
    GetComponent<Rigidbody>().useGravity = false;
    this.transform.position = theDest.position;
    this.transform.parent = GameObject.Find("Destination").transform;
}

void OnMouseUp()

{
this.transform.parent = null;



}
            }
    }

}
