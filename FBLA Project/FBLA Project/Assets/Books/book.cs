using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class book : MonoBehaviour {

    string URL = "https://cascadefalls.000webhostapp.com/bookmanage.php"; //databases
    string URL2 = "https://cascadefalls.000webhostapp.com/updatebook.php";

    public int bookid; //the id of the book

    public void HoldBook() //If the hold button is pressed
    {
        System.DateTime time = System.DateTime.Now.AddDays(7); //get the date of a week from now
        WWWForm form = new WWWForm(); //format for database, the book, who took it, and when is it due
        form.AddField("accidPost", login.accid);
        form.AddField("bookidPost", bookid);
        form.AddField("duedatePost", time.ToString());
        form.AddField("booknamePost", gameObject.name);
        form.AddField("typePost", 0);
        WWW www = new WWW(URL, form); //submit form
        WWWForm form2 = new WWWForm(); //change book availablity
        form2.AddField("condPost", 0);
        form2.AddField("bookidPost", bookid);
        WWW www2 = new WWW(URL2, form2);
        SceneManager.LoadScene(1);
    }
    public void CheckOutBook()
    {
        System.DateTime time = System.DateTime.Now.AddDays(14); //get the date of 2 weeks from now
        WWWForm form = new WWWForm(); //format for database, the book, who took it, and when is it due
        form.AddField("accidPost", login.accid);
        form.AddField("bookidPost", bookid);
        form.AddField("duedatePost", time.ToString());
        form.AddField("booknamePost", gameObject.name);
        form.AddField("typePost", 1);
        WWW www = new WWW(URL, form); //submit form
        WWWForm form2 = new WWWForm(); //change book availablity
        form2.AddField("condPost", 0);
        form2.AddField("bookidPost", bookid);
        WWW www2 = new WWW(URL2, form2);
        SceneManager.LoadScene(1);
    }
}
