using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinnyFloatyCube : MonoBehaviour {

	public float speed = 10f;
	private Rigidbody gameObjectsRigidBody;
	public GameObject player;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		transform.Rotate(Vector3.up * speed * Time.deltaTime);

	}

	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject == player ) {
			if (gameObjectsRigidBody == null) {
				gameObjectsRigidBody = this.gameObject.AddComponent<Rigidbody> ();
				gameObjectsRigidBody.mass = 5; 
			}
		} else {
			Destroy (this.gameObject);
		}

	}

}