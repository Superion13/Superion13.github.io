using UnityEngine;
using System.Collections;

public class Cpos : MonoBehaviour {
	
	public Camera MainCamera;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{

		if (Input.GetKeyDown (KeyCode.A)) {
			transform.position = new Vector3 (6, 6, -7);
			print (transform.position.x);
		}
		if (Input.GetKeyDown (KeyCode.W)) {
			transform.position = new Vector3 (16, 6, -7);
			print (transform.position.x);
		}
		if (Input.GetKeyDown (KeyCode.O)) {
			transform.position = new Vector3 (14, -2, -7);
			print (transform.position.x);
		}
		if (Input.GetKeyDown (KeyCode.C)) {
			transform.position = new Vector3 (0, -2, -7);
			print (transform.position.x);
		}
		if (Input.GetKeyDown (KeyCode.L)) {
			transform.position = new Vector3 (42, 6, -7);
			print (transform.position.x);
		}
		if (Input.GetKeyDown (KeyCode.Q)) {
			transform.position = new Vector3 (49, 6, -7);
			print (transform.position.x);
		}
		if (Input.GetKeyDown (KeyCode.N)) {
			transform.position = new Vector3 (-30, 6, -7);
			print (transform.position.x);
		}
		if (Input.GetKeyDown (KeyCode.Y)) {
			transform.position = new Vector3 (49, -2, -7);
			print (transform.position.x);
		}
		if (Input.GetKeyDown (KeyCode.T)) {
			transform.position = new Vector3 (0, 6, -7);
			print (transform.position.x);
		}
	
	}
}
