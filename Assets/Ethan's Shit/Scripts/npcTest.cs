using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npcTest : MonoBehaviour
{
    public Collider2D circleCollider;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))//&& Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("IT WORKSS");
        }
    }
}
