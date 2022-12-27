using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangeController : MonoBehaviour
{
    
    void Start()
    {
        SpriteRenderer sprite = gameObject.GetComponent<SpriteRenderer>();

        sprite.color = ColorChange.ChangeColor(sprite);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SpriteRenderer sprite = collision.gameObject.GetComponent<SpriteRenderer>();

        sprite.color = gameObject.GetComponent<SpriteRenderer>().color;

        Destroy(gameObject);
    }
}
