using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {
	
	// public variables
	public float moveSpeed = 3.0f;
	public float gravity = 9.81f;
    public float RotateSpeed = 40;

    private CharacterController myController;

	// Use this for initialization
	void Start () {
		// store a reference to the CharacterController component on this gameObject
		// it is much more efficient to use GetComponent() once in Start and store
		// the result rather than continually use etComponent() in the Update function
		myController = gameObject.GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        // Amount to Move
       // float MoveForward = Input.GetAxis("Horizontal")*  moveSpeed *Time.deltaTime;
        //float MoveRotate =  Input.GetAxis("Vertical")   * RotateSpeed* Time.deltaTime;

        // Move the player
        //myController.transform.Translate(Vector3.forward * MoveForward);
        //myController.transform.Translate(-Vector3.forward * MoveRotate);


        //transform.position -= myController.transform.right * (Input.GetAxis("Mouse X") * 0.03f);
        //transform.position += myController.transform.forward * (Input.GetAxis("Mouse Y") * 0.03f);
       // transform.eulerAngles.y -= (Input.GetAxis("Mouse X"));

    }
}
