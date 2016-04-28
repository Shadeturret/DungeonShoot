using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class gunScript : MonoBehaviour {

    public int bossHealth;
    public Animator animator;
    
    
    // Use this for initialization
	void Start ()
    {
        bossHealth = 100;
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit[] hits;
            hits = Physics.RaycastAll(transform.position, transform.forward, 15.0F);

            for (int i = 0; i < hits.Length; i++)
            {
                GameControls playerControls = GameObject.Find("FPSController").GetComponent<GameControls>();

                print(hits[i].collider.gameObject.name);

                if (hits[i].collider.gameObject.tag == "Skeleton")
                {
                    hits[i].collider.gameObject.SetActive(false);
                }

                if (hits[i].collider.gameObject.tag == "Boss")
                {
                    if(playerControls.invincible == true)
                    {
                        bossHealth = bossHealth - 10;
                        print(bossHealth);
                    }
                }


            }

            animator.SetBool("recoil", true);
        }

        if(bossHealth <= 0)
        {
            SceneManager.LoadScene("creditsPage");
        }
    }

}
