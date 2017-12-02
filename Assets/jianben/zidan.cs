using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zidan : MonoBehaviour {
	public GameObject effect1;
	// Use this for initialization


	void Update(){
		Destroy (gameObject,3);
	}
	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "allen") {
			if (effect1 != null) {
				Instantiate (effect1,transform.position,transform.rotation);
			}
			Destroy (gameObject);
		}
	}
}
