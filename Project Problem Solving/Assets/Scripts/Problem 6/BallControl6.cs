using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl6 : MonoBehaviour
{
    public float maxMoveSpeed = 10;
    public float smoothTime = 0.3f;
    Rigidbody2D rigidbody;

    Vector2 currentVelocity;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        rigidbody.position = Vector2.SmoothDamp(rigidbody.position, mousePosition, ref currentVelocity, smoothTime, maxMoveSpeed);
    }
}

