using UnityEngine;
using System.Collections;

public class rotateCube : MonoBehaviour {

	private float speed=20;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (speed * Time.deltaTime, speed * Time.deltaTime, speed * Time.deltaTime); 
	}
}
