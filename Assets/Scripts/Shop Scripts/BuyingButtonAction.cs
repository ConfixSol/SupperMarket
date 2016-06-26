using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using Soomla.Store;
public class BuyingButtonAction : MonoBehaviour {

	public string ItemId;
	public BuyMethods buyItemWith;
	Button button;

	[SerializeField]
	public enum BuyMethods
	{
		Market,
		VirtualCurrency,
		Upgrade
	}

	void Start(){
		button =	GetComponent<Button> ();
		if(button != null)
		button.onClick.AddListener (()=>BuyVirtualItem(ItemId));
	}

	void BuyVirtualItem(string itemId){
		if(itemId != null ){
			switch (buyItemWith) {

			case BuyMethods.VirtualCurrency:
					if (StoreInventory.CanAfford (itemId))
						StoreInventory.BuyItem (itemId);
					else
						Debug.Log ("You Dont Have Enough Balance to Buy this Product !");
					break;

			case BuyMethods.Upgrade:
				if (StoreInventory.CanAfford (itemId))
					StoreInventory.UpgradeGood (itemId);
				else
					Debug.Log ("You Dont Have Enough Balance to Buy this Product !");
				break;

			case BuyMethods.Market:
				SoomlaStore.BuyMarketItem (itemId,"Developer Payload");
				break;

			}
		}

	}
}
