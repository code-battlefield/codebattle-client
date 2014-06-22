using UnityEngine;
using System.Collections;

public class Flares : MonoBehaviour {
	private bool alive = true;
	

	// Use this for initialization
	void Start () {
		gameObject.rigidbody.AddForce(Vector3.up * 1000);
	}
	
	// Update is called once per frame
	void FixedUpdate() {
		if (gameObject.rigidbody.velocity.y == 0) return;
		if (alive && gameObject.rigidbody.velocity.y < 3f) {
			alive = false;
			gameObject.particleSystem.Stop(true);
			Destroy(gameObject, 1.5f);
		}
	}
	
	void Update () {
		
	}
}
