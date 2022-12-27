using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    
    
    public static Color ChangeColor(SpriteRenderer sprite)
    {
        Color[] colors = new Color[] {Color.blue, Color.red, Color.magenta, Color.green};
        
        int randomColor = Random.Range(0, 4);

        return colors[randomColor];
    }
}
