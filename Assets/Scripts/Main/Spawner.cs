using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
    public GameObject[] enemies;
    public float delayBetweenWaves;
    public float randomRangeOfSpawn;
    float timer;
    public bool spawning;
	// Use this for initialization
	void Start () {
        StartCoroutine(StartSpawning());
	}
	
	// Update is called once per frame
	void Update () {
		if(spawning)
        {
            timer += Time.deltaTime;
            if(timer >= delayBetweenWaves)
            {
                int rand = Random.Range(0, enemies.Length);
                Instantiate(enemies[rand], new Vector3(transform.position.x + Random.Range(-randomRangeOfSpawn, randomRangeOfSpawn), transform.position.y, transform.position.z), enemies[rand].transform.rotation);
                timer = 0f;
            }
        }
	}

    IEnumerator StartSpawning()
    {
        yield return new WaitForSeconds(2f);
        spawning = true;
    }
}
