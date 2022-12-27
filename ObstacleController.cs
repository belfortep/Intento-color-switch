using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    // Start is called before the first frame update

    SpriteRenderer obstacleSprite;

    void Start()
    {
        obstacleSprite = gameObject.GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SpriteRenderer playerSprite = collision.gameObject.GetComponent<SpriteRenderer>();

        if (playerSprite.color != obstacleSprite.color) {
            Destroy(collision.gameObject);
            //algo de gameOver
            //alguna animacion al perder
        }

    }
    
}
