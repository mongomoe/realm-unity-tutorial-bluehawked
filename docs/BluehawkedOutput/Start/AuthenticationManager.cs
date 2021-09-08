using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class AuthenticationManager : MonoBehaviour
{

    public static VisualElement root;
    public static Label loginSubtitle;
    public static Button loginAndStartButton;
    public static bool isShowingRegisterUI = false;
    public static string loggedInUser;
    public static TextField userInput;


    // Start is called before the first frame update
    void Start()
    {
        root = GetComponent<UIDocument>().rootVisualElement;

        loginSubtitle = root.Q<Label>("login-subtitle");
        loginAndStartButton = root.Q<Button>("login-and-start-button");

        userInput = root.Q<TextField>("username-input");


        loginAndStartButton.clicked += () =>
        {
            onPressLogin();
        };
    }

    public static void onPressLogin()
    {
        try
        {
            root.AddToClassList("hide");
        //  TODO: replace the loggedInUser variable with the user's input and pass it to RealmController's `setLoggedInUser()` method in order to authenticate
             loggedInUser = "<temporaryUserReplaceMe>";
            ScoreCardManager.setLoggedInUser(loggedInUser);
            LeaderboardManager.Instance.setLoggedInUser(loggedInUser);
        }
        catch (Exception ex)
        {
            Debug.Log("an exception was thrown:" + ex.Message);
        }
    }
}
