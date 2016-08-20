using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public Camera targetCamera;
	public GameObject model;
	public float speed = 10;

	[Header("Directions")]
	
	public GameObject up;
	public GameObject down;
	public GameObject left;
	public GameObject right;

	public GameObject upLeft;
	public GameObject upRight;
	public GameObject downLeft;
	public GameObject downRight;
	
	// Update is called once per frame
	void Update () {

		float x = 0, z = 0;
		GameObject direction = null;

		if (Input.GetKey ("w")) {
			x += -1;
			z += 1;
			direction = up;
		}

		if (Input.GetKey ("s")) {
			x += 1;
			z += -1;
			direction = down;
		}
		
		if (Input.GetKey ("a")) {
			x += -1;
			z += -1;
			direction = left;
		}

		if (Input.GetKey ("d")) {
			x += 1;
			z += 1;
			direction = right;
		}

		
		if (Input.GetKey ("w") && Input.GetKey ("a")) {
			direction = upLeft;
		} else if (Input.GetKey ("w") && Input.GetKey ("d")) {
			direction = upRight;
		} else if (Input.GetKey ("s") && Input.GetKey ("a")) {
			direction = downLeft;
		} else if (Input.GetKey ("s") && Input.GetKey ("d")) {
			direction = downRight;
		}

		transform.position = new Vector3 (
			transform.position.x + (x * Time.deltaTime * speed), 
			transform.position.y,
			transform.position.z + (z * Time.deltaTime * speed)
		);

		if (direction != null) {
			model.transform.LookAt (direction.transform);
		}
	}
}
