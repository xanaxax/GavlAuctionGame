using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadMenu : MonoBehaviour {

    // Load Functions for each of the diffrent screens
    public void LoadGameMenu() {
        SceneManager.LoadScene("Menu");
    }
    public void LoadGameAuction() {
        SceneManager.LoadScene("Auction");
    }
    public void LoadGamePortfolio() {
        SceneManager.LoadScene("Portfolio");
    }
    public void LoadGameRanking() {
        SceneManager.LoadScene("Ranking");
    }
    public void LoadGameResearch() {
        SceneManager.LoadScene("Research");

    }

}
