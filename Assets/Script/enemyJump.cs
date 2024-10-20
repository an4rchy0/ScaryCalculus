using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyJump : MonoBehaviour {
	public double amountToMove;
	public float speed;
	private float startx;
	private int direction;
	// Use this for initialization
	void Start () {
		direction = 0;
		startx = gameObject.transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {
		if(gameObject.transform.position.y < startx + amountToMove && direction == 0){ //kalo start y = 0 < amounttoMove = 3, sumbu x ke arah y plus
			gameObject.transform.position = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y + speed);
		}else if(gameObject.transform.position.y >= startx + amountToMove && direction==0){ //kalo obj udh kurang dari sama dengan 3(udah sampe batasnya 3), nilai direction==1
			direction = 1;
		}else if(gameObject.transform.position.y > startx && direction == 1){ //kalo obj udh kurang dari 0 & direction(udh memenuhi batasan sampe 3), dia akan ke arah positif
			gameObject.transform.position = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y - speed);
		}else if(gameObject.transform.position.y <= startx && direction == 1){ //klo ke arah positifnya udh sama dengan startx(dimana disini nilai startx =0) nilai direction = 0
			direction = 0;
		}
	}
}
