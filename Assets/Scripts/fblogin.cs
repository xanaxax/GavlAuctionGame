using UnityEngine;
using System;
using System.Collections.Generic;
using Facebook.Unity;


public static class FBLogin
{
    private static readonly List<string> readPermissions    = new List<string> {"public_profile","user_friends"};
    private static readonly List<string> publishPermissions = new List<string> {"publish_actions"};

    public static void PromptForLogin (Action callback = null)
    #Login via Facebook account
    {

        FB.LogInWithReadPermissions(readPermissions, delegate (ILoginResult result)
        {
            Debug.Log("LoginCallback");
            if (FB.IsLoggedIn)
            {
                Debug.Log("Logged in with ID: " + AccessToken.CurrentAccessToken.UserId +
                          "\nGranted Permissions: " + AccessToken.CurrentAccessToken.Permissions.ToCommaSeparateList());
            }
            else
            {
                if (result.Error != null)
                {
                    Debug.LogError(result.Error);
                }
                Debug.Log("Not Logged In");
            }
            if (callback != null)
            {
                callback();
            }
        });
    }

    public static void PromptForPublish (Action callback = null
    {

        FB.LogInWithPublishPermissions(publishPermissions, delegate (ILoginResult result)
        #Publish User results to Facebook account
        {
            Debug.Log("LoginCallback");
            if (FB.IsLoggedIn)
            {
                Debug.Log("Logged in with ID: " + AccessToken.CurrentAccessToken.UserId +
                          "\nGranted Permissions: " + AccessToken.CurrentAccessToken.Permissions.ToCommaSeparateList());
            }
            else
            {
                if (result.Error != null)
                {
                    Debug.LogError(result.Error);
                }
                Debug.Log("Not Logged In");
            }
            if (callback != null)
            {
                callback();
            }
        });
    }

}
