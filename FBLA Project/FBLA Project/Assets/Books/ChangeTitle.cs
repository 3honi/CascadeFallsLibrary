using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeTitle : MonoBehaviour {

    public Text title; //Title test
    public GameObject browse; //Buttons
    public GameObject manage;
    public GameObject map;

    public void Browse() //If the browse button is clicked
    {
        title.GetComponent<UnityEngine.UI.Text>().text = "Browse"; //Change test
        SceneManager.LoadScene(1); //Refresh the book list, this will ensure that the user always sees which books are still available
        browse.SetActive(true);
        manage.SetActive(false); //disable tab
        map.SetActive(false); //disable tab
    }
    public void Manage()
    {
        title.GetComponent<UnityEngine.UI.Text>().text = "Manage"; //If the manage button is clicked
        browse.SetActive(false); //disable tab
        manage.SetActive(true);
        map.SetActive(false); //disable tab
    }
    public void Map()
    {
        title.GetComponent<UnityEngine.UI.Text>().text = "Map"; //If the map button is clicked
        browse.SetActive(false); //disable tab
        manage.SetActive(false); //disable tab
        map.SetActive(true);
    }
}
