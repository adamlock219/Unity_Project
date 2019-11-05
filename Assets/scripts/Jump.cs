using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {

    [Range(1, 10)]
    public float JumpVelocity;

    Rigidbody2D rb;

    public static bool grounded;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        grounded = true;
    }

    // Update is called once per frame
    void Update () {
	if(Input.GetButtonDown("Jump") && grounded == true)
        {
            rb.velocity = Vector2.up * JumpVelocity;
        }
	}
}
