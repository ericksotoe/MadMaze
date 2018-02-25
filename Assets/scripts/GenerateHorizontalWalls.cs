using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateHorizontalWalls : MonoBehaviour
{

    public GameObject Wall;
    private GameObject wall;
    public GameObject RedBullseye;
    public GameObject GreenBullseye;
    public GameObject BlueBullseye;

    private GameObject bullEye;
    public const int PROBABILITY = 50;

    public LinkedList<int> noWalls = new LinkedList<int>();

    // Use this for initialization
    void Start()
    {

        noWalls.AddLast(811);
        noWalls.AddLast(812);
        noWalls.AddLast(813);
        noWalls.AddLast(841);
        noWalls.AddLast(842);
        noWalls.AddLast(843);

        RandomlyGenerateWalls();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void RandomlyGenerateWalls()
    {
        Vector3 initPosition = new Vector3(-145.0f, 5.0f, 140.0f);

        int randomInt = 0;
        for (int i = 0; i < Constants.MAZE_SIZE - 1; i++)
        {
            for (int j = 0; j < Constants.MAZE_SIZE; j++)
            {

                int boxCount = i * Constants.MAZE_SIZE + j + 1;
                randomInt = Random.Range(1, 100);

                if (!noWalls.Contains(boxCount) && randomInt <= PROBABILITY)
                {

                    wall = Instantiate(Wall);
                    wall.transform.position = new Vector3(initPosition.x, initPosition.y, initPosition.z);

                    int colorInt = Random.Range(1, 4);

                    switch (colorInt)
                    {

                        case Constants.RED:
                            bullEye = Instantiate(RedBullseye);
                            bullEye.transform.position = new Vector3(initPosition.x, initPosition.y, initPosition.z - 0.1f);
                            MyObjects.walls.AddLast(wall);
                            MyObjects.bullseyes.AddLast(bullEye);
                            break;

                        case Constants.GREEN:
                            bullEye = Instantiate(GreenBullseye);
                            bullEye.transform.position = new Vector3(initPosition.x, initPosition.y, initPosition.z - 0.1f);
                            MyObjects.walls.AddLast(wall);
                            MyObjects.bullseyes.AddLast(bullEye);
                            break;

                        case Constants.BLUE:
                            bullEye = Instantiate(BlueBullseye);
                            bullEye.transform.position = new Vector3(initPosition.x, initPosition.y, initPosition.z - 0.1f);
                            MyObjects.walls.AddLast(wall);
                            MyObjects.bullseyes.AddLast(bullEye);
                            break;
                    }


                }

                initPosition.x += Constants.WALL_SIZE;

            }

            initPosition.z -= Constants.WALL_SIZE;
            initPosition.x = -145.0f;
        }
    }
}
