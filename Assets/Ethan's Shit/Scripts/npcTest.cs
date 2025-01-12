using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npcTest : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            print("In");
        }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            print("Out");
        }
    }
}
//I hate this file dude this sucks