using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public GameObject OyunPedali;
    private Vector2 distance;
    private bool flag;
    void Start()
    {
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
}
