using UnityEngine;
using System.Collections;

public class gunScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if(Input.GetMouseButtonDown(0))
        {
            RaycastHit[] hits;
            hits = Physics.RaycastAll(transform.position, transform.forward, 15.0F);
        }
	}
    
}
