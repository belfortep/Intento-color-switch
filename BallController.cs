using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    
    Rigidbody2D rb;
    SpriteRenderer sprite;
    bool jumped = false;
    
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();

        sprite = gameObject.GetComponent<SpriteRenderer>();
    
        sprite.color = ColorChange.ChangeColor(sprite);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "ground" && jumped) {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if (Input.GetKeyDown("up")) {
            rb.velocity = new Vector2(0,0);
            rb.AddForce(new Vector2(0, 1000f));
            jumped = true;
        }
    }
}
