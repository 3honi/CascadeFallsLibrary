using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class manage : MonoBehaviour {

    ArrayList dues = new ArrayList(); //book dues
    public Text nameText; //UI Text
    public Text booksout;
    public Text booksoverdue;
    public Text booklist;
    int outcount; //How many books are out
    int latecount; //How many books are late

    IEnumerator Start() //Grabs information about the user's books
    {
        WWW www = new WWW("https://cascadefalls.000webhostapp.com/dues.php");
        yield return www;
        string duedata = www.text;
        string[] duearray = duedata.Split('|');
        for (int x = 0; x < duearray.Length; x++)
        {
            string[] temp = duearray[x].Split('`');
            if (temp[0] == login.accid.ToString()) //accid reference to login.cs
            {
                dues.Add(duearray[x]);
                outcount += 1;
                DateTime time = Convert.ToDateTime(temp[2]);
                if (time < System.DateTime.Now) //if the book is overdue
                {
                    latecount += 1; //add 1 to the late count
                }
            }
        }
        booksout.text = outcount+""; //convertin to string
        booksoverdue.text = latecount+"";
        string tempx = "";
        for (int x = 0; x < dues.Count; x++) //Display the book information
        {
            string[] duestring = (dues[x].ToString()).Split('`');
            string status = "";
            if (Convert.ToInt32(duestring[4]) == 1)
            {
                status = "Checked Out";
            }
            if (Convert.ToInt32(duestring[4]) == 0)
            {
                status = "Held";
            }
            tempx += "Book: " + (duestring[3].Split('('))[0] + System.Environment.NewLine + "Due: " + duestring[2] + System.Environment.NewLine + "Status: " + status + System.Environment.NewLine + System.Environment.NewLine;
        }
        booklist.text = tempx;
        nameText.text = login.accname + " " + login.accsurname; //reference to variables from login.cs
    }
    public void ReportBug()
    {
        Application.OpenURL("http://cascadefalls.000webhostapp.com/"); //Opens a link to the bug report form
    }
}
