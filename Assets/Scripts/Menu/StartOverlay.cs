using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartOverlay : MonoBehaviour {
    Image overlay;
    float timer = 0f;
	// Use this for initialization
	void Start () {
        overlay = GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if (timer <= 2f && timer > 1f)
        {
            overlay.color = Color.Lerp(Color.black, Color.clear, timer-1);
        }
        if(timer > 2f)
        {
            gameObject.SetActive(false);
        }
	}
}
