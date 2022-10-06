using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
 
    // Update is called once per frame

    //This will simulate a rotation animation
    void Update()
    {
        transform.Rotate(new Vector3(0f, 0f, 300f) * Time.deltaTime);

    }
}
