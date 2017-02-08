using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour {
    public float speed;
    public float rotx =15;
    public float roty = 30;
    public float rotz = 45;
    // Use this for initialization
    void Start () {
        speed = Random.Range(.5f, 2.0f);
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate (new Vector3(rotx, roty, rotz) * Time.deltaTime * speed);
	}
}
