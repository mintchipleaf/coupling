using UnityEngine;
using System.Collections;

public class MovementScript : MonoBehaviour {

	public int speedX = 1;
	public int speedY = 1;
	public int speedZ = 1;

	private Vector3 movement;
	private Vector3 rotation;


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey("left")){
			//movement = Vector3.left * speedX;
			rotation = Vector3.down;
		}

		if(Input.GetKey("right")){
			//movement = Vector3.right * speedX;
			rotation = Vector3.up;
		}

		if(Input.GetKey("w")){
			movement = transform.forward * speedZ;
		}

		if(Input.GetKey("s")){
			movement = transform.forward * speedZ * -1;
		}

		if(Input.GetKey("a")){
			movement = transform.right * speedX * -1;
		}

		if(Input.GetKey("d")){
			movement = transform.right * speedX;
		}
	}
	
	void FixedUpdate(){
		rigidbody.AddForce(movement);
		rigidbody.AddTorque(rotation);
		movement = Vector3.zero;
		rotation = Vector3.zero;
	}
}
