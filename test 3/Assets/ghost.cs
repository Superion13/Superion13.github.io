using UnityEngine;
using System.Collections;

public class ghost : MonoBehaviour {
	public GameObject cube;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.H)) {
			transform.position = new Vector3 (300, -3000, 0);
			print (transform.position.x);
		}
	
	}
}
