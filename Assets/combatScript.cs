using UnityEngine;
using System.Collections;

public class combatScript : MonoBehaviour {



    public float skeletonSpeed;
    
    
    // Use this for initialization
    void Start ()
    {
        skeletonSpeed = .05f;
        
	}

    // Update is called once per frame
    void Update()
    {
        RaycastHit[] hits;
        hits = Physics.RaycastAll(transform.position, transform.forward, 15.0F);

        print(hits.Length);
        for (int i = 0; i < hits.Length; i++)
        {
            if (hits[i].collider.gameObject.tag == "Player")
            {
                this.gameObject.transform.LookAt(hits[i].collider.gameObject.transform.position);
                print("hit");

                transform.position += transform.forward * skeletonSpeed;






            }
            else
            {
                print(hits[i].collider.gameObject.tag);
            }
        }
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

    public void huntPlayer()
    {
        
    }
}
