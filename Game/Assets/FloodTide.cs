using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloodTide : MonoBehaviour {

    GameObject player;
    public float speed = 0.5f;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
        FollowX();
        Progress();
	}

    void FollowX() {
        transform.position = new Vector2(player.transform.position.x, transform.position.y);
    }

    void Progress() {
        transform.position += Vector3.up * speed * Time.deltaTime;
    }
}
