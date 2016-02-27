using UnityEngine;
using System.Collections;

public class ghost2 : MonoBehaviour {
	public GameObject sphere
	;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.H)) {
			transform.position = new Vector3 (300, -1000, 0);
			print (transform.position.x);
		}

	}
}
