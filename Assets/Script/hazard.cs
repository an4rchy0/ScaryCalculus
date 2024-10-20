using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hazard : MonoBehaviour {
	public float respawnx, respawny;
	// Use this for initialization
	void Start () {

	}
	// Update is called once per frame
	void Update () {
		
	}
	private void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "Enemy"){
			gameObject.transform.position = new Vector2(respawnx, respawny);
		}
	}
}
