using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrabBehaviour : MonoBehaviour {

    public int eggPoints = 10;
    private ScoreKeeper scoreKeeper;
    public LevelManager levelManager;


	// Use this for initialization
	void Start () {
        scoreKeeper = GameObject.Find("Score").GetComponent<ScoreKeeper>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D coll) {
        if (coll.tag=="Egg") {
            Destroy(coll.gameObject);
            scoreKeeper.Score(eggPoints);
        }
        if (coll.tag=="Urchin"|| coll.tag=="Wave" || coll.tag=="Seagull") {
            Death();
        }
        
    }

    void Death() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
