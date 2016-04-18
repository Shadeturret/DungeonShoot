using UnityEngine;
using System.Collections;

public class combatScript : MonoBehaviour {

    

    // Use this for initialization
    void Start ()
    {
        
        
	}
	
	// Update is called once per frame
	void Update ()
    {
	    
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameControls playerControls = other.gameObject.GetComponent<GameControls>();
            if (playerControls.invincible == false)
            {
                
                playerControls.playerHealth = playerControls.playerHealth - 5;
                print(playerControls.playerHealth);
            }
            
        }
    }
}
