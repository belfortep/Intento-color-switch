using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    SpriteRenderer sprite;
    
    

    void Start()
    {
        
        Color[] colors = new Color[] {Color.blue, Color.red, Color.yellow, Color.green};

        rb = gameObject.GetComponent<Rigidbody2D>();

        sprite = gameObject.GetComponent<SpriteRenderer>();
        
        int randomColor = Random.Range(0, 4);

        sprite.color = colors[randomColor];

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "obstacle") {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if (Input.GetKeyDown("up")) {
            rb.velocity = new Vector2(0,0);
            rb.AddForce(new Vector2(0, 1000f));
        }
    }
}
