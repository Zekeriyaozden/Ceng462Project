using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallController : MonoBehaviour
{
    public GameObject OyunPedali;
    private Vector2 distance;
    public GameObject voiceBroke;
    public GameObject voiceKick;
    public int boxNumber;
    private bool flag;
    void Start()
    {
        GameObject.Find("57483265").transform.position = new Vector3(5.28f,0.801f,25f);
        flag = false;
        distance = transform.position - OyunPedali.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !flag)
        {

                gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(3f, 16f);
                flag = true;   
            
        }

        if (!flag)
        {
            StabilizeBallPedala(out var pedalPosition);
        }
    }

    private void StabilizeBallPedala(out Vector2 pedalPosition)
    {
        pedalPosition = new Vector2(OyunPedali.transform.position.x, OyunPedali.transform.position.y);
        transform.position = pedalPosition + distance;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Instantiate(voiceKick);
        }
        
        if (other.gameObject.tag == "Box")
        {
            Instantiate(voiceBroke);
            boxNumber--;
        }

        if (boxNumber == 0)
        {
            SceneManager.LoadScene(2);
        }
    }
}
