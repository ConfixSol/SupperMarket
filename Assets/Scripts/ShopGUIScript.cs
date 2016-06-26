using UnityEngine;
using System.Collections;

public class ShopGUIScript : MonoBehaviour {

	public GameObject coins;
	public GameObject machinies;
	public GameObject robots;
	public GameObject rails;
	public GameObject bags;
	public GameObject noAds;

	void Start(){
		coins.SetActive (true);
	}

	public void CoinsButton(){
		coins.SetActive (true);
		machinies.SetActive (false);
		robots.SetActive (false);
		rails.SetActive (false);
		bags.SetActive (false);
		noAds.SetActive (false);
	}

	public void MachiniesButton(){
		coins.SetActive (false);
		machinies.SetActive (true);
		robots.SetActive (false);
		rails.SetActive (false);
		bags.SetActive (false);
		noAds.SetActive (false);
	}

	public void RobotsButton(){
		coins.SetActive (false);
		machinies.SetActive (false);
		robots.SetActive (true);
		rails.SetActive (false);
		bags.SetActive (false);
		noAds.SetActive (false);
	}

	public void RailsButton(){
		coins.SetActive (false);
		machinies.SetActive (false);
		robots.SetActive (false);
		rails.SetActive (true);
		bags.SetActive (false);
		noAds.SetActive (false);
	}

	public void BagsButton(){
		coins.SetActive (false);
		machinies.SetActive (false);
		robots.SetActive (false);
		rails.SetActive (false);
		bags.SetActive (true);
		noAds.SetActive (false);
	}

	public void NoAdsButton(){
		coins.SetActive (false);
		machinies.SetActive (false);
		robots.SetActive (false);
		rails.SetActive (false);
		bags.SetActive (false);
		noAds.SetActive (true);
	}

}
