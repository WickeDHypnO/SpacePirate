using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Weapon : MonoBehaviour {
    public float damage;
    public float maxDamage;
    public float firingSpeed;
    public float maxFiringSpeed;

    public float cooldown;
    public Sprite weaponIcon;

    public float upgrades;
    public float maxUpgrades;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
