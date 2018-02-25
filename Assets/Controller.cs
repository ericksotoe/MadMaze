using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

    public GameObject Cube;
    private GameObject cube;


	// Use this for initialization
	void Start () {

        PlacePosition();		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void PlacePosition()
    {

        cube = Instantiate(Cube);
        cube.transform.position = new Vector3(1.0f, 1.0f, 1.0f);
    }
}
