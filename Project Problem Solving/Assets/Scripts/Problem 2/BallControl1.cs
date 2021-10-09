using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl1 : MonoBehaviour
{
    Rigidbody2D rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = gameObject.GetComponent<Rigidbody2D>();
        rigidbody.velocity = new Vector2(2, 2);
    }


}
