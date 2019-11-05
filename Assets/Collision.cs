using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D collision)
    {
        
        if(collision.gameObject.name == "Diamond" || collision.gameObject.name == "Diamond(Clone)")
        {
            Debug.Log("collided");
            if (Health.health < 100)
            {
                Health.health += 10;
            }
            Destroy(collision.gameObject);
            Debug.Log(Health.health);
        }

        if (collision.gameObject.name == "Square" || collision.gameObject.name == "Square(Clone)")
        {
            Debug.Log("collided");
          
            Health.health -= 30;
            
            Destroy(collision.gameObject);

            Debug.Log(Health.health);
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
