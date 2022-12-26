using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationController : MonoBehaviour
{

    float time = 0;

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        gameObject.transform.eulerAngles = new Vector3(0, 0, time * 36f);

        if (time >= 10f ) {
            time = 0;
        }
    }
}
