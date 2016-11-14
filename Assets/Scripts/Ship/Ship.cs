using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Ship : MonoBehaviour {
    public float health;
    public float maxHealth;
    public float speed;
    public float maxSpeed;
    public int healthUpgrades;
    public int speedUpgrades;

    public Weapon defaulMaintWeapon;
    public Weapon currentMainWeapon;
    public Weapon[] mainWeapons;

    public Weapon defaultSecondaryWeapon;
    public Weapon currentSecondaryWeapon;
    public Weapon[] secondaryWeapons;

    public Transform mainWeaponShotPosition;
    public Transform secondaryWeaponPosition;

    public int maxMainWeponUpgrades;
    public int maxSecondaryWeponUpgrades;

    public Sprite shipIcon;
    public MeshFilter shipMesh;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
