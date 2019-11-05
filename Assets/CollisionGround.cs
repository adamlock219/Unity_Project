using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionGround : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Square" || collision.gameObject.name == "Square(Clone)")
        {
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.name == "Player" && Jump.grounded == false)
        {
            Jump.grounded = true;
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Player" && Jump.grounded == false)
        {
            Jump.grounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Player")
        {
            Jump.grounded = false;
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
