using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10;
    // Update is called once per frame
    protected virtual void FixedUpdate()
    {
        float translation = Input.GetAxis("Vertical");

        transform.position += new Vector3(0, translation * speed, 0);
    }
}
