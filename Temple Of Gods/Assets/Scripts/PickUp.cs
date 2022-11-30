using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{


Inventory invScript;

public bool item;
public GameObject itemIcon;

bool pickedUp = false;


void Start()
{
 
 invScript = GameObject.FindWithTag("GameController").GetComponent<Inventory>();

}

void OnTriggerStay (Collider player)
{
 if (player.tag == "Player")
    {
        if (Input.GetKeyDown(KeyCode.E) && !pickedUp)

        {
            pickedUp = true;
            GameObject i = Instantiate(itemIcon);
            i.transform.SetParent(invScript.invTab.transform);
            Destroy(gameObject);
        }
    }

}



}
