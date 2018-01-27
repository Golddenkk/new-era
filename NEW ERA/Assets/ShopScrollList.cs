using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public struct Item
{
    public string name;
    public Sprite icon;
    public uint price;
}

public class ShopScrollList : MonoBehaviour {
    public List<Item> items;
    public Transform contentPanel;
    public ShopScrollList other;
    public SimpleObjectPool buttonObjectPool;
    public Text goldDisplay;
    public uint gold = 100;

	// Use this for initialization
	void Start () {
		
	}
	
	private void AddButtons()
    {
        foreach (var item in items)
        {
            GameObject newButton = buttonObjectPool.GetObject();
        }
    }
}
