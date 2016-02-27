using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {

	public GameObject cube;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update ()
	{

		if (Input.GetKeyDown (KeyCode.G)) {
			gameObject.GetComponent<Renderer> ().material.color = Color.red;
		}
		if (Input.GetKeyDown (KeyCode.Z)) {
			transform.position = new Vector3 (2, 2, 2);
			print (transform.position.x);
		}
		if (Input.GetKeyDown (KeyCode.M)) {
			transform.position = new Vector3 (0, -1, 0);
			print (transform.position.x);
		}
		if (Input.GetKeyDown (KeyCode.P)) {
			transform.position = new Vector3 (1, 1, 1);
			print (transform.position.x);
		}
			


	}


}