using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateWalls : MonoBehaviour {

    public GameObject Wall;
    private GameObject wall;

    public const int WALL_SIZE = 10;
    public const double HALF = 2.0;

	// Use this for initialization
	void Start () {

        RandomlyGenerateWalls();
	}
	
	// Update is called once per frame
	void Update () {

	}

    private void RandomlyGenerateWalls()
    {
        wall = Instantiate(Wall);
        wall.transform.position = new Vector3(5.0f, 5.0f, 0.0f);
    }
}
