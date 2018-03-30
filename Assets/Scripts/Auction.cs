using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using Firebase;
//using Firebase.Database;
//using Firebase.Unity.Editor;

public class Auction : MonoBehaviour {
	public GameObject LogText;
	public GameObject CurrentPrice;
	public int bidnumber = 100000;
	public int bidincrease;
	public Button BidBtn;
	public int userbalance = 500000;
	public int topbid = 100000;
	public int topbidincrease;
	//topbid need to be accessed from Firebase server

	public void RandomGenerate()
	{
		if (userbalance < bidnumber) {
			LogText.GetComponent<Text> ().text += "\n You don't have the balance!";
		} 
		else if (topbid < bidnumber) {
			LogText.GetComponent<Text> ().text += "\n You Win the Bid!";
			//return Firebase server with bidding end signal
		}

		else {
			bidincrease = Random.Range (100000, 500000);
			bidnumber = bidnumber + bidincrease;
			topbidincrease = Random.Range (-100000, 100000);
			topbid = bidnumber + topbidincrease;
			LogText.GetComponent<Text> ().text += "\n New bid: $" + bidnumber; 
			CurrentPrice.GetComponent<Text> ().text = "$" + topbid;
			//return the Firebase server with user's new bid number
		}

	}
		
}
