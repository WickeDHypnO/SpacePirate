using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMovement : MonoBehaviour {
    public bool move;
    public AnimationCurve movementCurve;
    public Vector3 startPosition;
    public Vector3 endPosition;
    public bool useRelativePosition;
    public float movementMultiplier;
    Vector3 chachedPosition;
    float timer;
	// Use this for initialization
	void Start()
    {
        chachedPosition = transform.position;
    }
	// Update is called once per frame
	void Update () {
		if(move)
        {
            timer += Time.deltaTime * movementMultiplier;
            if(useRelativePosition)
            {
                transform.position = Vector3.Lerp(chachedPosition, chachedPosition + endPosition, movementCurve.Evaluate( timer ));
            }
            else
            {
                transform.position = Vector3.Lerp(startPosition, endPosition, movementCurve.Evaluate(timer));
            }
            if(timer > 1)
            {
                move = false;
            }
        }
	}
}
