using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speed = 2;

    private void Start()
    {
        Vector3 randomDirection = new Vector3(Random.value, Random.value, Random.value);
        transform.Rotate(randomDirection);
    }

    private void FixedUpdate()
    {
        transform.position += Vector3.one * speed;
    }
}
