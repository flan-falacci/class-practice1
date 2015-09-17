using UnityEngine;
using System.Collections;

public class movetest : MonoBehaviour {

	public float moveSpeed = 1f;
	public float turnSpeed = 200f; 
	
	// Update is called once per frame
	void Update () {
		//to make frame rate independent, usually multiply by "Time.deltaTime"
		// 0.1 (10FPS) 0.01 (100FPS) 

	if (Input.GetKey (KeyCode.W)) {
			transform.position += new Vector3(0f, 0f, moveSpeed * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.S)) {
			transform.Translate ( new Vector3(0f, 0f, -moveSpeed * Time.deltaTime));
			                     }

		if (Input.GetKey (KeyCode.A)) {
			transform.eulerAngles += new Vector3(0f, -turnSpeed * Time.deltaTime, 0f);
		}
		if (Input.GetKey (KeyCode.D)) {
			transform.Rotate (0f, turnSpeed * Time.deltaTime, 0f);
		}
		if (Input.GetKey (KeyCode.Space)) {
			transform.position += new Vector3 (0f, moveSpeed * Time.deltaTime, 0f);
		}

}
}
