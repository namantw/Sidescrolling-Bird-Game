using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlls : MonoBehaviour
{
    public Rigidbody2D rb;
    public static bool isDead = false;


    // Use this for initialization
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = new Vector2(8, rb.velocity.y);

        if (Input.GetMouseButtonDown(0))
        {
            //rb.AddForce(new Vector2(0, 600f));
            rb.velocity = new Vector2(8, 12);
        }

    }

}
