using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using Firebase;
//using Firebase.Database;
//using Firebase.Unity.Editor;

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
		topbid = Random.Range (100000, 800000);
		// Get topbid code from firebase
		//	.GetReference("Leaders")
		//	.GetValueAsync().ContinueWith(task => {
		//		if (task.IsFaulted) {
					// Handle the error...
		//		}
		//		else if (task.IsCompleted) {
		//			DataSnapshot snapshot = task.Result;
					// Do something with snapshot...
		//		}
		//  Listen to firebase events: topbid changes 
		//	.GetReference("Leaders")
		//	.ValueChanged += HandleValueChanged;
		//}
		//void HandleValueChanged(object sender, ValueChangedEventArgs args) {
		//	if (args.DatabaseError != null) {
		//		Debug.LogError(args.DatabaseError.Message);
		//	return;
		//	}
		// Do something with the data in args.Snapshot
		//
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
