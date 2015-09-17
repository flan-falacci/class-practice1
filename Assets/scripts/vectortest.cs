using UnityEngine;
using System.Collections;

public class vectortest : MonoBehaviour {
	public Transform sphere; 
	public Transform cube;


	
	// Update is called once per frame
	void Update () {
	if (Input.GetKey (KeyCode.U)) {
			cube.position += new Vector3 (0f, 1f, 0f);
		}
		Debug.DrawLine (sphere.position, cube.position, Color.cyan);

		Debug.DrawLine (Vector3.zero, new Vector3 (1f, 5f, 2f));
		Debug.DrawLine (new Vector3(1f, 5f, 2f), Vector3.one);
	}
}
