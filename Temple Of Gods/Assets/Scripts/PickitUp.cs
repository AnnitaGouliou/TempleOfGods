using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickitUp : MonoBehaviour
{
  

public Transform theDest;

void Onclick()
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
