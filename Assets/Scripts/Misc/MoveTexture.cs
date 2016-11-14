using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTexture : MonoBehaviour {
    Material mat;
    public float moveMultiplier;
	// Use this for initialization
	void Start () {
        mat = GetComponent<Renderer>().material;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        mat.mainTextureOffset += new Vector2(0, moveMultiplier);
	}
}
