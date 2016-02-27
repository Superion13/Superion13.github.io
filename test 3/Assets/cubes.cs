using UnityEngine;
using System.Collections;

public class cubes : MonoBehaviour {

	public GameObject sphere;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update ()
	{

		if (Input.GetKeyDown (KeyCode.U)) {
			transform.position = new Vector3 (1, 4, 0);
			print (transform.position.x);
		}
		if (Input.GetKeyDown (KeyCode.D)) {
			transform.position = new Vector3 (4, 1, 0);
			print (transform.position.x);
		}
		if (Input.GetKeyDown (KeyCode.J)) {
			transform.position = new Vector3 (7, 4, 0);
			print (transform.position.x);
		}
		if (Input.GetKeyDown (KeyCode.F)) {
			transform.position = new Vector3 (4, 1, 0);
			print (transform.position.x);
		}
		if (Input.GetKeyDown (KeyCode.W)) {
			transform.position = new Vector3 (12, 4, 0);
			print (transform.position.x);
		}
		if (Input.GetKeyDown (KeyCode.O)) {
			transform.position = new Vector3 (17, 4, 0);
			print (transform.position.x);
		}
		if (Input.GetKeyDown (KeyCode.O)) {
			transform.position = new Vector3 (21, -2, 0);
			print (transform.position.x);
		}
		if (Input.GetKeyDown (KeyCode.I)) {
			transform.position = new Vector3 (14, -2, 0);
			print (transform.position.x);
		}
		if (Input.GetKeyDown (KeyCode.C)) {
			transform.position = new Vector3 (-2, -2, 0);
			print (transform.position.x);
		}
		if (Input.GetKeyDown (KeyCode.S)) {
			transform.position = new Vector3 (5, -2, 0);
			print (transform.position.x);
		}
		if (Input.GetKeyDown (KeyCode.L)) {
			transform.position = new Vector3 (37, 4, 0);
			print (transform.position.x);
		}
		if (Input.GetKeyDown (KeyCode.Q)) {
			transform.position = new Vector3 (42, 4, 0);
			print (transform.position.x);
		}
		if (Input.GetKeyDown (KeyCode.N)) {
			transform.position = new Vector3 (-30, 4, 0);
			print (transform.position.x);
		}
		if (Input.GetKeyDown (KeyCode.Y)) {
			transform.position = new Vector3 (47, -2, 0);
			print (transform.position.x);
		}
		if (Input.GetKeyDown (KeyCode.T)) {
			transform.position = new Vector3 (-3, 4, 0);
			print (transform.position.x);
		}



	}


}