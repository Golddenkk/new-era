using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	private int amountOfGold = 0;
	List<Item> items;
	// Use this for initialization
	void Start () {
		items.Add (new Beer ());
		items.Add (new Wood ());
		items.Add (new Brick ());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
