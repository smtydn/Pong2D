using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speed = 200;

    private Vector3 direction = new Vector3(1, 1, 0);
    
    private void FixedUpdate()
    {
        transform.Translate(direction * Time.deltaTime * speed);
    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        // Bounce from upper and lower bounds
        if (coll.collider.name == "UpperBound" || coll.collider.name == "LowerBound")
        {
            direction.y *= -1;
            return;
        }

        // If the ball hits the right or the left boundary, then it is a score.
        if (coll.collider.name == "RightBound")
        {
            GameManager.instance.IncrementPlayerScore();   
        }
        else
        {
            GameManager.instance.IncrementEnemyScore();
        }
        // After scoring, scene should be restarted.
        GameManager.instance.Restart();
    }
}
