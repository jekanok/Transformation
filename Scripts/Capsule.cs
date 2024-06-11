using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : MonoBehaviour
{
    public float speed = 3f;

    private float _distance = 1f;

    private Vector3 _minScale = new Vector3(1f, 1f, 1f);
    private Vector3 _maxScale = new Vector3(2f, 2f, 2f);

    void Update()
    {
        float size = Mathf.PingPong(Time.time * speed, _distance);
        transform.localScale = Vector3.Lerp(_minScale, _maxScale, size);
    }
}