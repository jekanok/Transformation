using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotateScale : MonoBehaviour
{
    public float moveSpeed = 2.0f;
    public float rotationSpeed = 30.0f;
    public Vector3 scaleSpeed = new Vector3(0.1f, 0.1f, 0.1f);

    void Update()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);

        transform.localScale += scaleSpeed * Time.deltaTime;
    }
}