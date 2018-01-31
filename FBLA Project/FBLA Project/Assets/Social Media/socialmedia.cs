using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class socialmedia : MonoBehaviour {

	public void twitter() //Opens a link to tweet about this amazing app
    {
        Application.OpenURL("https://ctt.ec/U05iO");
    }
    public void goodreads() //Opens a link to goodreads, where they can discover what their peers are reading
    {
        Application.OpenURL("https://www.goodreads.com/");
    }
}
