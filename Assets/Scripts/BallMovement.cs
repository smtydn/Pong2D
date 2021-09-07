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
        // Increment the player's score and restart the scene.
        if (coll.collider.name == "RightBound")
        {
            GameManager.instance.IncrementPlayerScore();
            GameManager.instance.Restart();
        }
        else if (coll.collider.name == "LeftBound")
        {
            GameManager.instance.IncrementEnemyScore();
            GameManager.instance.Restart();
        }

        // If the ball is hit by the enemy or by the player, then 
        // rotate it to the counter direction.
        if (coll.collider.tag == "Player")
        {
            direction.x *= -1;
        }
    }
}
