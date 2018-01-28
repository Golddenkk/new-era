using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ListButton : MonoBehaviour {
    public Button button;
    public Text nameLabel;
    public Text priceLabel;
    public Image icon;

	private Item item;
	private ShopScrollList scrollList;

	// Use this for initialization
	void Start () {
		button.onClick.AddListener(HandleClick);
	}
	
	public void Setup(Item currentItem, ShopScrollList currentShopScrollList) {
		item = currentItem;
		nameLabel.text = item.name;
		icon.sprite = item.icon;
		priceLabel.text = item.price.ToString();
		scrollList = currentShopScrollList;
	}

	public void HandleClick() {
		scrollList.TryTransferToOther(item);
	}
}
