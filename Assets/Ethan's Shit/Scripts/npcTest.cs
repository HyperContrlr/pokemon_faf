using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npcTest : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
{
    if (other.gameObject.CompareTag("Player"))
    {
        print("In");
    }
}
private void OnTriggerExit2D(Collider2D other)
{
    if (other.gameObject.CompareTag("Player"))
    {
        print("Out");
    }
}
}
//I hate this file dude this sucks