using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Auction : MonoBehaviour {
	public GameObject LogText;
	public int bidnumber = 100000;
	public int bidincrease;
	public Button BidBtn;
	public int userbalance = 500000;
	public int topbid;
	//topbid need to be accessed from Firebase server

	public void RandomGenerate()
	{
		topbid = Random.Range (100000, 500000);
		if (userbalance < bidnumber) {
			LogText.GetComponent<Text> ().text += "\n You don't have the balance!";
		} 
		else if (topbid < bidnumber) {
			LogText.GetComponent<Text> ().text += "\n You Win the Bid!";
			//return Firebase server with bidding end signal
		}

		else {
			bidincrease = Random.Range (100000, 200000);
			bidnumber = bidnumber + bidincrease;
			LogText.GetComponent<Text> ().text += "\n New bid: $" + bidnumber; 
			//return the Firebase server with user's new bid number
		}

	}
		
}
