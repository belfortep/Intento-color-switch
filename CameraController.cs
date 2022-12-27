using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CameraController : MonoBehaviour
{
    public Transform groundPosition;
    public Transform playerPosition;
    const int diferencia = 6;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerPosition.position.y - diferencia > groundPosition.position.y) {
            groundPosition.position = new Vector2(0, playerPosition.position.y - diferencia);
        }
    }
}
