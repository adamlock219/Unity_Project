using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour {

   

   

	// Use this for initialization
	void Start () {
        InvokeRepeating("Spawn", 0, 0.5f);
	}

    void Spawn()
    {
        GameObject ob = Resources.Load("Square") as GameObject;
        int SpawnCounter = 1;

        float x = Random.Range(-10, 10);
        float y = 8;
        for (int i = 0; i < SpawnCounter; i++)
        {
            GameObject go = Instantiate(ob) as GameObject;
            go.transform.position = new Vector2(x, y);
        }
    }
	// Update is called once per frame
	void Update () {
		
	}
}
