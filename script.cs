using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour {
	public float jumpSpeed = 5f;
	public Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		 rb = GetComponent <Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}
	void FixedUpdate() {
		transform.position += Vector3.right * Time.deltaTime * CameraControl.MapSpeed;
		 if (Input.GetMouseButton(0)) {
			rb.AddForce(Vector3.up * jumpSpeed);
			Debug.Log("press");
		}
		
	}
}
