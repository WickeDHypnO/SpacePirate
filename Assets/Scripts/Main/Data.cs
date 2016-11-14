using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class Data : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public static void LoadData()
    {

    }

    public static void SaveData()
    {
        BinaryFormatter bf = new BinaryFormatter();
        //Application.persistentDataPath is a string, so if you wanted you can put that into debug.log if you want to know where save games are located
        FileStream file = File.Create(Application.persistentDataPath + "/GameData.data"); //you can call it anything you want
        bf.Serialize(file, GameController.Instance.ships);
        bf.Serialize(file, Stats.bossesDestroyed);
        bf.Serialize(file, Stats.shipsDestroyed);
        bf.Serialize(file, Stats.secondaryWeaponUses);
        file.Close();
    }
}
