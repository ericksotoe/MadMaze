using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateVerticalWalls : MonoBehaviour {

    public GameObject Wall;
    private GameObject wall;

    public const int PROBABILITY = 50;

    public LinkedList<int> noWalls = new LinkedList<int>();

    // Use this for initialization
    void Start () {

        noWalls.AddLast(841);
        noWalls.AddLast(842);
        noWalls.AddLast(843);
        noWalls.AddLast(871);
        noWalls.AddLast(872);
        noWalls.AddLast(873);

        RandomlyGenerateWalls();
    }

    // Update is called once per frame
    void Update () {

        
    }

    private void RandomlyGenerateWalls()
    {

        Vector3 initPosition = new Vector3(-140.0f, 5.0f, 145.0f);
        int randomInt = 0;
        for (int i = 0; i < Constants.MAZE_SIZE; i++)
        {
            for (int j = 0; j < Constants.MAZE_SIZE - 1; j++)
            {
                randomInt = Random.Range(1, 100);
                int boxCount = i * Constants.MAZE_SIZE + j + 1;

                if (!noWalls.Contains(boxCount) && randomInt <= PROBABILITY)
                {
                    wall = Instantiate(Wall);
                    wall.transform.position = new Vector3(initPosition.x, initPosition.y, initPosition.z);
                }

                initPosition.x += Constants.WALL_SIZE;

            }

            initPosition.z -= Constants.WALL_SIZE;
            initPosition.x = -140.0f;
        }
    }
}
