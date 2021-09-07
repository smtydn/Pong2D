using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : PlayerMovement 
{
    public GameObject ball;

    protected override void FixedUpdate()
    {
        float translation = 0.0f;
        if (ball.transform.position.y > transform.position.y)
        {
            translation = 1.0f;
        }
        else if (ball.transform.position.y < transform.position.y)
        {
            translation = -1.0f;
        }

        transform.position += new Vector3(0, translation * speed, 0);
    }
}
