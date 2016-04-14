using UnityEngine;
using System.Collections;

public class combatScript : MonoBehaviour {

    public int playerHealth;
    
    // Use this for initialization
	void Start ()
    {
        playerHealth = 100;
        
	}
	
	// Update is called once per frame
	void Update ()
    {
	    
	}

    void onTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            playerHealth = playerHealth - 5;
        }
    }
}
