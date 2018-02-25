using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceCubes : MonoBehaviour {

    public GameObject RedCube;
    public GameObject GreenCube;
    public GameObject BlueCube;
    private GameObject cube;

    public const int PROBABILITY = 20;

    // Use this for initialization
    void Start()
    {

        RandomlyPlaceCube();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void RandomlyPlaceCube()
    {

        Vector3 initPosition = new Vector3(-145, 20, -135);
        int randomInt = 0;
        int cubeRandom = 0;

        for (int i = 0; i < Constants.MAZE_SIZE; i++)
        {

            for (int j = 0; j < Constants.MAZE_SIZE; j++)
            {

                randomInt = Random.Range(1, 100);
                cubeRandom = Random.Range(1, 4);

                if (randomInt <= PROBABILITY)
                {

                    switch (cubeRandom)
                    {

                        case Constants.RED:
                            cube = Instantiate(RedCube);
                            break;

                        case Constants.GREEN:
                            cube = Instantiate(GreenCube);
                            break;

                        case Constants.BLUE:
                            cube = Instantiate(BlueCube);
                            break;
                    }
                    cube.transform.position = new Vector3(initPosition.x, initPosition.y, initPosition.z);
                }

                initPosition.x += Constants.WALL_SIZE;
            }

            initPosition.z += Constants.WALL_SIZE;
            initPosition.x = -145.0f;
        }
    }
}
