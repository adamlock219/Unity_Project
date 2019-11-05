using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

    
	// Use this for initialization
	void Start () {
        InvokeRepeating("spawn", 10, 6f);
    }

    void spawn()
    {
        int SpawnCounter = 1;

        GameObject ob = Resources.Load("Diamond") as GameObject;

        float x = Random.Range(-10, 10);
        float y = Random.Range(0, 7);

        for (int i=0; i<SpawnCounter; i++)
        {
            GameObject go = Instantiate(ob) as GameObject;
            go.transform.position = new Vector2(x, y);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
