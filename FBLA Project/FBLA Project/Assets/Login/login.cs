using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class login : MonoBehaviour {

    public InputField usernameinput; //Username and password fields
    public InputField passwordinput;
    public Text passwordWrong; //What to say if the login details are incorrect
    ArrayList accounts = new ArrayList(); //A list of accounts
    public static int accid; //Variables referenced throughout the application
    public static string accname;
    public static string accsurname;

	IEnumerator Start () { //On launch, grab the account data from the database
        WWW logindb = new WWW("https://cascadefalls.000webhostapp.com/login.php");
        yield return logindb;
        //passwordWrong.text = logindb.text;
        string logindata = logindb.text;
        string[] accountst = logindata.Split('|');
        for (int x = 0; x < accountst.Length; x++)
        {
            accounts.Add(accountst[x]);
        }
    }
	
	void Update () {
        if (Input.GetKeyDown(KeyCode.Return)) //If the "enter" key is hit, login
        {
            bool logged = logintest();
            if (logged == true)
            {
                int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
                SceneManager.LoadScene(nextSceneIndex);
            }
            else if (logged == false)
            {

                passwordWrong.text = "*Incorrect Username or Password*";
            }
        }
    }
    public void Login() //Login upon clicking on the login button
    {
        bool logged = logintest(); //logintest will return true or false based on the login information
        if (logged == true)
        {
            int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1; //Move on
            SceneManager.LoadScene(nextSceneIndex);
        }
        else
        {
            passwordWrong.text = "*Incorrect Username or Password*"; //Wrong details
        }
    }
    bool logintest() //Check database for login
    {
        for (int x = 0; x < accounts.Count-1; x++)
        {
            string temp = accounts[x].ToString();
            string[] acctemp = temp.Split('`');
            if (acctemp[1] == usernameinput.text) //If username matches with a username in the database
            {
                if (acctemp[2] == passwordinput.text) //If password matches with a password in the database
                {
                    accid = Convert.ToInt32(acctemp[0]); //grab these variables, they're needed later
                    accname = acctemp[3].ToString();
                    accsurname = acctemp[4].ToString();
                    return true; //login and return true
                }
            }
        }
        return false;
    }
    public void goreg() //Registration
    {
        SceneManager.LoadScene(2); //Go to the registration page
    }
}
