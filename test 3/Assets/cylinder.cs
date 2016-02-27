using UnityEngine;
using System.Collections;

public class cylinder : MonoBehaviour {

	public GameObject Capsule;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update ()
	{

		if (Input.GetKeyDown (KeyCode.I)) {
			transform.position = new Vector3 (210, -2, 0);
			print (transform.position.x);
		}



	}


}