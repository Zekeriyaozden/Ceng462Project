using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pedal : MonoBehaviour {
    [SerializeField] float ekranGenisligiUnitCinsinden = 16f;
// Use this for initialization
    void Start () {
    }
// Update is called once per frame
    void Update () {
        
        float farePozUnitCinsinden = Input.mousePosition.x / Screen.width * ekranGenisligiUnitCinsinden;
        Vector2 pedalPozisyonu = new Vector2(farePozUnitCinsinden, transform.position.y);
        pedalPozisyonu.x = Mathf.Clamp(pedalPozisyonu.x, 1.52f, 8.45f);
        transform.position = pedalPozisyonu;
        
    }
}
