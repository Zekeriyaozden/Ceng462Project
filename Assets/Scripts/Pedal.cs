using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pedal : MonoBehaviour {
    [SerializeField] float ekranGenisligiUnitCinsinden = 16f;
    void Start () {
        Debug.Log("Basladı");
        
    }
// Update is called once per frame
    void Update () {
        
        float farePozUnitCinsinden = Input.mousePosition.x / Screen.width * ekranGenisligiUnitCinsinden;
        Vector2 pedalPozisyonu = new Vector2(farePozUnitCinsinden, transform.position.y);
        pedalPozisyonu.x = Mathf.Clamp(pedalPozisyonu.x, 1.52f, 8.45f);
        transform.position = pedalPozisyonu;
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        GameObject.Find("Ball").GetComponent<Rigidbody2D>().AddForce(new Vector2(0f,5f));
    }
}
