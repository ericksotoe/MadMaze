using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MyObjects : MonoBehaviour {

    public static LinkedList<GameObject> walls = new LinkedList<GameObject>();
    public static LinkedList<GameObject> bullseyes = new LinkedList<GameObject>();


    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
        for (int i = 0; i < bullseyes.Count; i++)
        {

            if (bullseyes.ElementAt(i) == null)
            {

                Destroy(walls.ElementAt(i));
                bullseyes.Remove(bullseyes.ElementAt(i));
                walls.Remove(walls.ElementAt(i));
            }
        }
	}
}
