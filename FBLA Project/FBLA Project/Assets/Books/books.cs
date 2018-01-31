using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class books : MonoBehaviour {

    ArrayList bookinfo = new ArrayList(); //Stores the data obtained from the database
    public GameObject[] booklist; //The container for the scroller
    float bookindex = 920f; //This is the height of the next book in the list

    IEnumerator Start() { //Grabs information about the books at the start
        WWW bookdata = new WWW("https://cascadefalls.000webhostapp.com/bookdata.php");
        yield return bookdata;
        string[] data = bookdata.text.Split('|');
        for (int x = 0; x < data.Length; x++)
        {
            bookinfo.Add(data[x]);
        }
        UpdateBookList(); //This will update the book list, and remove books that are not available
    }

    public void LogOut() //Logs out of the app, and returns to the log in screen
    {
        SceneManager.LoadScene(0);
    }

    void UpdateBookList() //Updates book list
    {
        for (int x = 0; x < transform.childCount; x++) //Has to clear all of the books first before placing a new list
        {
            Destroy(transform.GetChild(x).gameObject);
        }
        for (int x = 0; x < bookinfo.Count-1; x++) //Takes information from the php file
        {
            string temp = (bookinfo[x].ToString());
            string a = temp.Split('`')[4];
            if (a == "1") //If the book is still available
            {
                CreateBookObject(x); //Add it to the list
            }
        }
    }
    void CreateBookObject(int number) //Creates the book object to be displayed
    {
        GameObject x = Instantiate(booklist[number], position: new Vector2(0, 0), rotation: Quaternion.identity, parent: transform); //creates the book
        x.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, bookindex); //uses bookindex from above to place book in appropriate location
        bookindex -= 160; //move the bookindex down for the next book
    }
}
