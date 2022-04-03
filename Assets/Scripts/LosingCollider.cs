using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LosingCollider : MonoBehaviour
{
    public GameObject gameOver;

    private void OnTriggerEnter2D(Collider2D other)
    {
        gameOver.SetActive(true);
    }
}
