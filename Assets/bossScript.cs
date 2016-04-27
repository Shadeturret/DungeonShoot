using UnityEngine;
using System.Collections;

public class bossScript : MonoBehaviour {

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


        for (int i = 0; i < hits.Length; i++)
        {
            if (hits[i].collider.gameObject.tag == "Player")
            {
                this.gameObject.transform.LookAt(hits[i].collider.gameObject.transform.position);
                print("hit");

                transform.position += transform.forward * skeletonSpeed;






            }
        }

    }
}
