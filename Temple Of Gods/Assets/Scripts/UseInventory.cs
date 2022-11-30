using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UseInventory : MonoBehaviour
{
    

public bool items;

GameObject inv;
GameObject player;


void Start()
{
    inv = GameObject.FindWithTag("GameController");
    player = GameObject.FindWithTag("Player");
}



}
