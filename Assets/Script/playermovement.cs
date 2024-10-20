using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour {

	Rigidbody2D rb;
	public float ms, jf, gcrad;
	public Transform gc;
	public LayerMask wig;
	private bool onG;

	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		float horiz = Input.GetAxisRaw("Horizontal"); //a,d,kiri,kanan
		rb.velocity = new Vector2(ms * horiz, rb.velocity.y);

		onG = Physics2D.OverlapCircle(gc.position, gcrad, wig);
		if(Input.GetButtonDown("Jump") && onG){ //space
			rb.AddForce(new Vector2(0, jf));
		}
	}
}
