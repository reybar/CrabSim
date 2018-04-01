using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveSelf : MonoBehaviour {

    GameObject wave;

	// Use this for initialization
	void Start () {
        wave = GameObject.FindGameObjectWithTag("Wave");
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.y+7f < wave.transform.position.y) {
            Destroy(gameObject);
        }
	}
}
