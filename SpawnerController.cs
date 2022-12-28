using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    public GameObject[] possibleObstacles;
    public Transform playerPosition;
    public GameObject colorChanger;
    GameObject obstaclePrefab;
    Transform obstaclePosition;
    GameObject oldObstaclePrefab;

    // Start is called before the first frame update
    void Start()
    {
        obstaclePrefab = possibleObstacles[0];
        obstaclePosition = obstaclePrefab.GetComponent<Transform>();

        obstaclePrefab = Instantiate(obstaclePrefab, new Vector3(0, 0 ,0), new Quaternion());

    }

    // Update is called once per frame
    void Update()
    {   
        if (playerPosition.position.y > obstaclePosition.position.y + 5) {

            Vector3 position = new Vector3(0, obstaclePosition.position.y + 20, 0);

            oldObstaclePrefab = obstaclePrefab;

            int randomObstacle = Random.Range(0, 2);

            obstaclePrefab = possibleObstacles[randomObstacle];
            
            obstaclePrefab = Instantiate(obstaclePrefab, position, new Quaternion());

            Instantiate(colorChanger, position, new Quaternion());

            obstaclePosition = obstaclePrefab.GetComponent<Transform>();

            Destroy(oldObstaclePrefab);
        }
        
    }
}
