using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateHorizontalWalls : MonoBehaviour
{

    public GameObject Wall;
    private GameObject wall;

    public const int WALL_SIZE = 10;
    public const double HALF = 2.0;
    public const int MAZE_SIZE = 10;

    // Use this for initialization
    void Start()
    {

        RandomlyGenerateWalls();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void RandomlyGenerateWalls()
    {

        Vector3 initPosition = new Vector3(-45.0f, 5.0f, 40.0f);

        for (int i = 0; i < MAZE_SIZE - 1; i++)
        {
            for (int j = 0; j < MAZE_SIZE; j++)
            {
                wall = Instantiate(Wall);
                wall.transform.position = new Vector3(initPosition.x, initPosition.y, initPosition.z);
                initPosition.x += WALL_SIZE;
            }

            initPosition.z -= WALL_SIZE;
            initPosition.x = -45.0f;
        }
    }
}
