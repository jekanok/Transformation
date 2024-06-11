using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    private Vector3 rotate = new Vector3(0, 150, 0);

    void Update()
    {
        transform.Rotate(rotate * Time.deltaTime);
    }
}