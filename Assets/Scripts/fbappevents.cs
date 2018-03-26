using UnityEngine;
using System.Collections.Generic;
using Facebook.Unity;


public static class FBAppEvents
{
    private static readonly string EVENT_NAME_GAME_PLAYED = "game_played";
    private static readonly string EVENT_PARAM_SCORE = "score";

    public static void LaunchEvent ()
    {
        FB.ActivateApp();
    }

    public static void GameComplete (int score)
    {
        // setup parameters
        var param = new Dictionary<string, object>();
        param[EVENT_PARAM_SCORE] = score;
        // log event
        FB.LogAppEvent(EVENT_NAME_GAME_PLAYED, null, param);
    }

    // Appevent for microtranaction
    public static void SpentCoins (int coins, string item)
    {
        // setup parameters
        var param = new Dictionary<string, object>();
        param[AppEventParameterName.ContentID] = item;
        // log event
        FB.LogAppEvent(AppEventName.SpentCredits, (float)coins, param);
    }
}
