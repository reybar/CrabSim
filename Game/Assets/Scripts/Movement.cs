using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    public Vector2 currentTile;
    public float moveSpeed = 200;

	// Use this for initialization
	void Start () {
        Debug.Log(Screen.width);
	}
	
	// Update is called once per frame
	void Update () {
        Move();
        foreach (Touch touch in Input.touches) {
            if (touch.position.x < Screen.width / 3) {
                transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
            }
            if (touch.position.x > Screen.width / 3*2) {
                transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
            }
        }
   }

    void Move() {
        if (Input.GetKey(KeyCode.A)) {
            transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D)) {
            transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);

        }
    }

    void OnTriggerStay2D (Collider2D coll){
        if (coll.tag=="Terrain") {
            currentTile = coll.transform.position;
        }
    }

}
