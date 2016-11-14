using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipShooting : MonoBehaviour {
    public float delayBeetweenShots = 0.5f;
    public GameObject shot;
    public Transform shotStartPoint;
    float timer;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if(timer >= delayBeetweenShots)
        {
            Instantiate(shot, shotStartPoint.position, shot.transform.rotation);
            timer = 0f;
        }
	}
}
