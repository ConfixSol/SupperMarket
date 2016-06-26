using UnityEngine;
using System.Collections;
using Soomla.Store;
public class SMStore : IStoreAssets {
	#region IStoreAssets implementation

	public int GetVersion ()
	{
		return 0;
	}

	public VirtualCurrency[] GetCurrencies ()
	{
		return new VirtualCurrency[]{Currency};
	}

	public VirtualGood[] GetGoods ()
	{
		return new VirtualGood[]{Machine,Machine_Upgrade_1,Machine_Upgrade_2,Machine_Upgrade_3,
			Rail,Rail_Upgrade_1,Rail_Upgrade_2,Rail_Upgrade_3,
			Bag,UnlimtedBags,
			Robot,
			NoAds};
	}

	public VirtualCurrencyPack[] GetCurrencyPacks ()
	{
		return new VirtualCurrencyPack[]{CurrencyPack_1,CurrencyPack_2,CurrencyPack_3,CurrencyPack_4};
	}

	public VirtualCategory[] GetCategories ()
	{
		return new VirtualCategory[]{};
	}

	#endregion

	/* Define the prodcut ids in google play */
	const string CURRENCY_PACK_1_PRODUCT_ID = "A";
	const string CURRENCY_PACK_2_PRODUCT_ID = "B";
	const string CURRENCY_PACK_3_PRODUCT_ID = "C";
	const string CURRENCY_PACK_4_PRODUCT_ID = "D";

	const string NO_ADS_PRODUCT_ID = "E";

	const string UNLIMITED_BAGS_PRODUCT_ID = "F";

	/*Constant strings */

	const string currency = "currency";

	/* Virtual Currecy */
	public static VirtualCurrency Currency = new VirtualCurrency(
		"Coins",
		"Description",
		currency);

	/* Virtual Currecy Packs*/
	public static VirtualCurrencyPack CurrencyPack_1 = new VirtualCurrencyPack(
		"Currency Pack 1",
		"Description",
		"currency_pack_1",
		100,
		currency,
		new PurchaseWithMarket(CURRENCY_PACK_1_PRODUCT_ID,10));

	public static VirtualCurrencyPack CurrencyPack_2 = new VirtualCurrencyPack(
		"Currency Pack 2",
		"Description",
		"currency_pack_2",
		200,
		currency,
		new PurchaseWithMarket(CURRENCY_PACK_2_PRODUCT_ID,20));

	public static VirtualCurrencyPack CurrencyPack_3 = new VirtualCurrencyPack(
		"Currency Pack 3",
		"Description",
		"currency_pack_3",
		1000,
		currency,
		new PurchaseWithMarket(CURRENCY_PACK_3_PRODUCT_ID,30));

	public static VirtualCurrencyPack CurrencyPack_4 = new VirtualCurrencyPack(
		"Currency Pack 4",
		"Description",
		"currency_pack_4",
		2500,
		currency,
		new PurchaseWithMarket(CURRENCY_PACK_4_PRODUCT_ID,10));

	/* Virtual Good Machinie with its Upgrades  */

	public static VirtualGood Machine = new SingleUseVG(
		"Machine",
		"Description",
		"machine",
		new PurchaseWithVirtualItem(currency,10));

	public static VirtualGood Machine_Upgrade_1 = new UpgradeVG (
	"machine",
		"machine_upgrade_2",
		null,
		"Machine Upgrade 1",
		"Description",
		"machine_upgrade_1",
		new PurchaseWithVirtualItem(currency,20));

	public static VirtualGood Machine_Upgrade_2 = new UpgradeVG (
		"machine",
		"machine_upgrade_3",
		"machine_upgrade_1",
		"Machine Upgrade 2",
		"Description",
		"machine_upgrade_2",
		new PurchaseWithVirtualItem(currency,20));
	
	public static VirtualGood Machine_Upgrade_3 = new UpgradeVG (
		"machine",
		null,
		"machine_upgrade_2",
		"Machine Upgrade 3",
		"Description",
		"machine_upgrade_3",
		new PurchaseWithVirtualItem(currency,20));
	
	/* Virtual Good Rail with its Upgrades */

	public static VirtualGood Rail = new SingleUseVG(
		"Rail",
		"Description",
		"rail",
		new PurchaseWithVirtualItem(currency,10));

	public static VirtualGood Rail_Upgrade_1 = new UpgradeVG (
		"rail",
		"rail_upgrade_2",
		null,
		"Rail Upgrade 1",
		"Description",
		"rail_upgrade_1",
		new PurchaseWithVirtualItem(currency,20));

	public static VirtualGood Rail_Upgrade_2 = new UpgradeVG (
		"rail",
		"rail_upgrade_3",
		"rail_upgrade_1",
		"Rail Upgrade 2",
		"Description",
		"rail_upgrade_2",
		new PurchaseWithVirtualItem(currency,20));

	public static VirtualGood Rail_Upgrade_3 = new UpgradeVG (
		"rail",
		null,
		"rail_upgrade_2",
		"Rail Upgrade 3",
		"Description",
		"rail_upgrade_3",
		new PurchaseWithVirtualItem(currency,20));

	/* Virtual Good Bags */

	public static VirtualGood Bag = new SingleUseVG(
		"Bag",
		"Description",
		"bag",
		new PurchaseWithVirtualItem(currency,10));

	public static VirtualGood UnlimtedBags = new LifetimeVG(
		"Unlimted Bags",
		"Description",
		"unlimited_bags",
		new PurchaseWithMarket(UNLIMITED_BAGS_PRODUCT_ID,10));

	/* Virtual Good Robots */

	public static VirtualGood Robot = new SingleUseVG(
		"Robot",
		"Description",
		"robot",
		new PurchaseWithVirtualItem(currency,10));

	/* Virtual Good No Ads */

	public static VirtualGood NoAds = new LifetimeVG(
		"No Ads",
		"Description",
		"noAds",
		new PurchaseWithMarket(NO_ADS_PRODUCT_ID,10));




}
