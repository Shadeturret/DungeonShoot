using UnityEngine;
using System.Collections;

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
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Pickup")
        {
            invincible = true;
            print("invicible");
        }
    }


}
