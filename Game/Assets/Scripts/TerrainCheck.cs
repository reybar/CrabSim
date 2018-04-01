using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainCheck : MonoBehaviour {

    public Vector2 currentTile;
    public GameObject player;
    public GameObject terrain;
    public Transform[] checkers;
    public LayerMask whatIsTerrain;
    private int xOffset = 25;
    private int yOffset = 14;

    GameObject wave;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        wave = GameObject.FindGameObjectWithTag("Wave");
	}
	
	// Update is called once per frame
	void Update () {
        currentTile = player.GetComponent<Movement>().currentTile;
        TerrainChecking();
	}

    void TerrainChecking() {
        foreach (Transform checker in transform) {
            bool terrainExist = Physics2D.OverlapCircle(checker.position, 0.1f, whatIsTerrain);

            if (!terrainExist && checker.position.y>wave.transform.position.y) {

                string name = checker.name;
                GameObject newTerrain = Instantiate(terrain);
                switch (name) { 
                    case "L":
                        newTerrain.transform.position = new Vector2(currentTile.x - xOffset, currentTile.y);
                        break;
                    case "UL":
                        newTerrain.transform.position = new Vector2(currentTile.x - xOffset, currentTile.y + yOffset);
                        break;
                    case "U":
                        newTerrain.transform.position = new Vector2(currentTile.x, currentTile.y + yOffset);
                        break;
                    case "UR":
                        newTerrain.transform.position = new Vector2(currentTile.x + xOffset, currentTile.y + yOffset);
                        break;
                    case "R":
                        newTerrain.transform.position = new Vector2(currentTile.x + xOffset, currentTile.y);
                        break;
                    case "DR":
                        newTerrain.transform.position = new Vector2(currentTile.x + xOffset, currentTile.y - yOffset);
                        break;
                    case "D":
                        newTerrain.transform.position = new Vector2(currentTile.x, currentTile.y - yOffset);
                        break;
                    case "DL":
                        newTerrain.transform.position = new Vector2(currentTile.x - xOffset, currentTile.y - yOffset);
                        break;
                }
                
            }
        }
        
    }
}
