using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotScript : MonoBehaviour {
    public float movementMutliplier;
    public float damage;
    public float timeToDestroy;
	// Use this for initialization
	void Start () {
        Destroy(gameObject, timeToDestroy);
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(transform.forward * movementMutliplier);
	}

    void OnCollisionEnter(Collision col)
    {
        var script = col.collider.GetComponent<EnemyShipScript>();
        if (script != null)
        {
            script.health -= damage;
            if(script.health <= 0)
            {
                script.DestroyShip();
            }
        }
        Destroy(gameObject);
    }
}
