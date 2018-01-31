using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class register : MonoBehaviour {

    string URL = "https://cascadefalls.000webhostapp.com/register.php"; //registering + all the inputs
    public InputField username;
    public InputField password;
    public InputField firstname;
    public InputField lastname;
    public Text warning;
    ArrayList accounts = new ArrayList(); //data from the account database

    IEnumerator Start() //Get the data from the account database, needs to match up to ensure there aren't two of the same usernames
    {
        WWW logindb = new WWW("https://cascadefalls.000webhostapp.com/login.php");
        yield return logindb;
        string logindata = logindb.text;
        string[] accountst = logindata.Split('|');
        for (int x = 0; x < accountst.Length-1; x++)
        {
            string[] t = accountst[x].Split('`');
            accounts.Add(t[1]);
        }
    }

    // Update is called once per frame
    void Update () {
	}
    public void Register()
    {
        for (int x = 0; x < accounts.Count-1; x++)
        {
            string a = accounts[x].ToString();
            if (a == username.text) //if there is an identical existing username
            {
                warning.text = ("*The username is taken*"); //send warning
                return;
            }
        }
        if (username.text.Length > 0 && password.text.Length > 0 && !accounts.Contains(username.text)) //Ensure there is at least a username/password and the username is unique
        {
            WWWForm form = new WWWForm(); //format form for database
            form.AddField("usernamePost", username.text);
            form.AddField("passwordPost", password.text);
            form.AddField("firstnamePost", firstname.text);
            form.AddField("lastnamePost", lastname.text);
            WWW www = new WWW(URL, form); //submit
            SceneManager.LoadScene(0); //Head back to login page
        }
        else
        {
            warning.text = ("*Please enter a username/password*"); //There isn't a username/password
        }
    }
}
