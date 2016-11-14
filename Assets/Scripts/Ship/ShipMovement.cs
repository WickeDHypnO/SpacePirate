using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour {
    public float movementMultiplier = 1f;
    public float movementBounds;
    public bool moveLeft, moveRight;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(moveLeft)
        {
            transform.position += Vector3.left * movementMultiplier * Time.deltaTime;
        }
        if (moveRight)
        {
            transform.position += -Vector3.left * movementMultiplier * Time.deltaTime;
        }
        if (transform.position.x > movementBounds)
        {
            transform.position = new Vector3(movementBounds, transform.position.y, transform.position.z);
        }
        if(transform.position.x < -movementBounds)
        {
            transform.position = new Vector3(-movementBounds, transform.position.y, transform.position.z);
        }
        
	}

    public void MoveLeft(bool move)
    {
        moveLeft = move;
    }

    public void MoveRight(bool move)
    {
        moveRight = move;
    }
}
