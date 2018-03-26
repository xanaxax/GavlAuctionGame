using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SocialPlatforms;

public class GameCenterTest : MonoBehaviour {
	
	public Transform scoreText;
	public Transform checkScoreboardButton;
	public Transform sendScoreButton;
	public Transform slider;
	
	private long sliderVal;
	
	void Awake () {
		// Entering Code to update the current score here
	}
	
	void Start () {
		// Authenticate
		Social.localUser.Authenticate (ProcessAuthentication);
	}
	
	// Login to iOS Game Center
	void ProcessAuthentication (bool success) {
       	   	if (success) {
            		Debug.Log ("Auth success");
        	} else {
			Debug.Log ("Failed to auth");
		}     
    	}
	
	// Update score to iOS GameCenter
	void ReportScore (long score, string leaderboardID) {
		Debug.Log ("Updating score " + score + " on leaderboard " + leaderboardID);
		Social.ReportScore (score, leaderboardID, success => {
			Debug.Log(success ? "Update successfully" : "Failed to update");
		});
	}

	} 
}
