using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    public float speed = 2.0f;

    private float _distance = 7f;

    private Vector3 _startPosition;

    public void Start()
    {
        _startPosition = transform.position;
    }

    void Update()
    {
        float z =_startPosition.z + Mathf.PingPong(Time.time * speed, _distance);
        transform.position = new Vector3(transform.position.x, transform.position.y, z);
    }
}