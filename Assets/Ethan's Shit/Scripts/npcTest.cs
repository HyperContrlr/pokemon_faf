using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npcTest : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))//&& Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("IT FUKIN WORKSS");
        }
    }
}
