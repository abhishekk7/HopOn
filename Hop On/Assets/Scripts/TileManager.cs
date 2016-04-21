using UnityEngine;
using System.Collections;

public class TileManager : MonoBehaviour {


    public GameObject leftTilePrefab;
    public GameObject rightTilePrefab;
    public GameObject topTilePrefab;
    public GameObject currentTile;
	// Use this for initialization
	void Start () {
        
            SpawnTile();
	}
	
	// Update is called once per frame
	void Update () {
        SpawnTile();

	}

    public void SpawnTile()
    {
        
        int nextTileDecider = Random.Range(1, 4);
        switch(nextTileDecider)
        {
            case 1:
                currentTile = (GameObject)Instantiate(leftTilePrefab, currentTile.transform.GetChild(0).transform.GetChild(0).position, Quaternion.identity);
                break;
            case 2:
                currentTile = (GameObject)Instantiate(topTilePrefab, currentTile.transform.GetChild(0).transform.GetChild(2).position, Quaternion.identity);
                break;
            case 3:
                currentTile = (GameObject)Instantiate(rightTilePrefab, currentTile.transform.GetChild(0).transform.GetChild(1).position, Quaternion.identity);
                break;
        }
        
    }
}
