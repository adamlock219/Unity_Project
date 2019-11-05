using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speed : MonoBehaviour {

    public float BulletSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(transform.up * BulletSpeed * Time.deltaTime);


	}
}
