using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnviromentSpawner : MonoBehaviour {

    public GameObject[] stones;
    public GameObject eggs;

    public LayerMask dontSpawnHere;    

    private float xSpacing = 8.33f;
    private float ySpacing = 4.66f;
    private float xLocalMin;
    private float yLocalMin;
    private float xLocalMax;
    private float yLocalMax;


	// Use this for initialization
	void Start () {
        xLocalMin = transform.position.x - 12.5f;
        yLocalMin = transform.position.y - 7f;
        xLocalMax = transform.position.x + 12.5f;
        yLocalMax = transform.position.y + 7f;


        Stones();
        ScoreEggs();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void Stones() {
        for (int i = 0; i < 3; i++) {
            for (int j = 0; j < 3; j++) {
                GameObject rock = Instantiate(stones[Random.Range(0, stones.Length)]);
                rock.transform.parent = transform;
                rock.transform.position = new Vector2(xLocalMin+ 2.083f+xSpacing*i, yLocalMin + 1.166f+ySpacing*j);
            }
        }
        for (int i = 0; i < 3; i++) {
            for (int j = 0; j < 3; j++) {
                GameObject rock = Instantiate(stones[Random.Range(0, stones.Length)]);
                rock.transform.parent = transform;
                rock.transform.position = new Vector2(xLocalMin+ 6.25f + xSpacing * i, yLocalMin+ 3.5f + ySpacing * j);
            }
        }
    }

    void ScoreEggs() {
        int count = 0;
        while(count<20) {
            Vector2 spawnPosition = new Vector2(Random.Range(xLocalMin, xLocalMax), Random.Range(yLocalMin, yLocalMax));
            if(!Physics2D.OverlapCircle(spawnPosition,0.5f,dontSpawnHere)) {
                float randValue = Random.value;
                if (randValue < .5f) {
                    GameObject egg = Instantiate(eggs) as GameObject;
                    egg.transform.parent = transform;
                    egg.transform.position = spawnPosition; 
                }
                count++;
            }
        }
    }
}
