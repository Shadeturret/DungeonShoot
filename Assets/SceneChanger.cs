using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        Cursor.visible = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void startGame()
    {
        SceneManager.LoadScene("Level1");
    }

    public void backToMenu()
    {
        SceneManager.LoadScene("startMenu");
    }

    public void showCredits()
    {
        SceneManager.LoadScene("creditsPage");
    }

    public void quitTheGame()
    {
        Application.Quit();
    }
}
