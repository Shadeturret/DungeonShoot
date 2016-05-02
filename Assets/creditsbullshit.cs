using UnityEngine;
using System.Collections;

public class creditsbullshit : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        Cursor.visible = true;
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if(Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.visible = !Cursor.visible;
        }
	}

    void Awake()
    {
        Cursor.visible = true;
    }
}
