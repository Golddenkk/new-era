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
		RefreshDisplay();
	}

    void RefreshDisplay() {
        goldDisplay.text = $"Gold: {gold.ToString()}";
        RemoveButtons();
        AddButtons();
    }

    private void RemoveButtons() {
        while (contentPanel.childCount > 0) {
            GameObject toRemove = transform.GetChild(0).gameObject;
            buttonObjectPool.ReturnObject(toRemove);
        }
    }
	
	private void AddButtons() {
        foreach (var item in items) {
            GameObject newButton = buttonObjectPool.GetObject();
            newButton.transform.SetParent(contentPanel);

            ListButton button = newButton.GetComponent<ListButton>();
            button.Setup(item, this);
        }
    }

    public void TryTransferToOther(Item item) {
        if (other.gold >= item.price) {
            gold += item.price;
            other.gold -= item.price;

            AddItem(item, other);
            RemoveItem(item, this);

            RefreshDisplay();
            other.RefreshDisplay();
        }
    }

    private void AddItem(Item item, ShopScrollList shopList) {
        shopList.items.Add(item);
    }

    private void RemoveItem(Item item, ShopScrollList shopList) {
        for (int i = shopList.items.Count - 1; i >= 0, --i) {
            if (shopList.items[i] == item) {
                shopList.items.RemoveAt(i);
            }
        }
    }
}
