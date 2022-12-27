using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{

    public GameObject obstaclePrefab;
    public Transform playerPosition;
    public GameObject colorChanger;
    Transform obstaclePosition;
    GameObject oldObstaclePrefab;

    // Start is called before the first frame update
    void Start()
    {
        obstaclePosition = obstaclePrefab.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {   
        if (playerPosition.position.y > obstaclePosition.position.y + 5) {

            Vector3 position = new Vector3(0, obstaclePosition.position.y + 10, 0);

            oldObstaclePrefab = obstaclePrefab;
            
            obstaclePrefab = Instantiate(obstaclePrefab, position, new Quaternion());

            Instantiate(colorChanger, position, new Quaternion());

            obstaclePosition = obstaclePrefab.GetComponent<Transform>();

            Destroy(oldObstaclePrefab);
        }
        
    }
}
