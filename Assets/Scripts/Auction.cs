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
	//bidnumber is the real bid number fetched from Firebase server.
	public Button BidBtn;
	public int userbalance = 500000;
	public int housevalue;
	public int othersbid = 100000;
	public int othersbidincrease;
	// othersbid is randomized variable to decide others follow your bid or hold.
	public bool auctionopen = false;
	public bool auctionwait = false;
	public bool auctionend = false;
	public float auctiontime;

	void start (){
	}

	void Update(){
		if (Time.time > 2 && auctionwait == false) {
			auctionopen = true;
		}
		if (auctionwait == true && (Time.time - auctiontime) > 10) {
			auctionend = true;
		}
	}

	public void RandomGenerate()
	{
		if(auctionopen == true) {

			if (userbalance < bidnumber) {
				LogText.GetComponent<Text> ().text += "\n You don't have the balance!";
			} 
			else if (othersbid < bidnumber) {
				LogText.GetComponent<Text> ().text += "\n You Win the Bid!";
				//return Firebase server with bidding end signal
			}
			else {
				bidincrease = Random.Range (100000, 500000);
				bidnumber = bidnumber + bidincrease;
				othersbidincrease = Random.Range (-100000, 100000);
				othersbid = bidnumber + othersbidincrease;
				LogText.GetComponent<Text> ().text += "\n New bid: $" + bidnumber; 
				//CurrentPrice.GetComponent<Text> ().text = "$" + othersbid;
				//return the Firebase server with user's new bid number	
				auctionwait = true;
				auctiontime = Time.time;
			}

		}
		if(auctionopen == false) {
			LogText.GetComponent<Text> ().text += "\n Bidding not ready!";
		}
		if(auctionend == true) {
			LogText.GetComponent<Text> ().text += "\n Bidding Finished!";
			housevalue = Random.Range (500000, 1000000);
			userbalance = userbalance - bidnumber;
			userbalance = userbalance + (int) (housevalue * 0.9);
			LogText.GetComponent<Text> ().text += "\n Your Account Balance" + userbalance;
		}
	}
		
}
