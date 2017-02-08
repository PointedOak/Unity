using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moves : MonoBehaviour {
    public float horizontalSpeed=.25f;
    public float verticalSpeed = .25f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey (KeyCode.LeftArrow)) {
                gameObject.transform.Translate(-horizontalSpeed,0,0);
            }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.Translate(horizontalSpeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            gameObject.transform.Translate(0, 0, verticalSpeed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            gameObject.transform.Translate(0, 0, -verticalSpeed);
        }
    }
}
