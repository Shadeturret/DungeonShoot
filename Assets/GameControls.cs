using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameControls : MonoBehaviour {


    public int playerHealth;
    public bool invincible;
    
    // Use this for initialization
	void Start ()
    {
        playerHealth = 100;
        invincible = false;
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if(playerHealth <= 0)
        {
            SceneManager.LoadScene("startMenu");
        }
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Pickup")
        {
            invincible = true;
            
            other.gameObject.SetActive(false);
        }
    }


}
