using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Indicator : MonoBehaviour {
    GameObject indicator;
    public GameObject seagull;
    public float delay=1f;
    public float killTime = 2f;
    public float thrust = 2f;

	// Use this for initialization
	void Start () {
        indicator = GameObject.FindGameObjectWithTag("Indicator");
        StartCoroutine(SeagullDelay());

	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector2(transform.position.x, indicator.transform.position.y);
	}

    IEnumerator SeagullDelay() {
        yield return new WaitForSeconds(delay);
        Seagull();
    }

    void Seagull(){
        Destroy(gameObject);
        GameObject enemy = Instantiate(seagull, new Vector2(transform.position.x, transform.position.y - 2f), transform.rotation);
        enemy.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 1) * thrust);
        Destroy(enemy, killTime);

    }
}
