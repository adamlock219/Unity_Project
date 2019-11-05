using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCollision : MonoBehaviour {

    Transform Enemy;
	// Use this for initialization
	void Start () {
        var enemy = Instantiate(Enemy) as Transform;
        Physics2D.IgnoreCollision(enemy.GetComponent<Collider2D>(), GetComponent<Collider2D>());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
