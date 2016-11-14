using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShipScript : MonoBehaviour {
    public float movementMultiplier;
    public float health;
    public GameObject[] explosion;
	// Update is called once per frame
	void Update () {
        transform.position += -Vector3.forward * movementMultiplier * Time.deltaTime;
	}

    public void DestroyShip()
    {
        int rand = Random.Range(0, explosion.Length);
        Instantiate(explosion[rand], transform.position, explosion[rand].transform.rotation);
        Destroy(gameObject);
    }
}
