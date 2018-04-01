using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSeagull : MonoBehaviour {

    public GameObject seagull;
    public GameObject screech;
    public float delay= 2f;
    float timer = 0;
    public float chance = 0.1f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if (timer>delay) {
            timer = 0;
            foreach (Transform spawnPos in transform) {
                float spawnChance = Random.value;
                if (spawnChance < chance) {
                    Instantiate (screech, spawnPos.position,transform.rotation);

                }
            }
        }
	}
}
