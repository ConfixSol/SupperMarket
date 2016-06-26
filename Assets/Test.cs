using UnityEngine;
using System.Collections;
using Soomla.Store;
public class Test : MonoBehaviour {


	public void Test1 () {
		StoreInventory.BuyItem(SMStore.Robot.ItemId);
	}
}
