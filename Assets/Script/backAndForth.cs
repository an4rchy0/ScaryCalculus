using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backAndForth : MonoBehaviour {
	public double amountToMove;
	public float speed;
	private float startx;
	private int direction;
	// Use this for initialization
	void Start () {
		direction = 0;
		startx = gameObject.transform.position.x;
	}
	// Update is called once per frame
	void Update () {
		if(gameObject.transform.position.x > startx + amountToMove && direction == 0){ //kalo start x = 0 > amounttoMove = -12, sumbu x ke arah minus
			gameObject.transform.position = new Vector2(gameObject.transform.position.x - speed, gameObject.transform.position.y);
		}else if(gameObject.transform.position.x <= startx + amountToMove && direction==0){ //kalo obj udh kurang dari sama dengan -12(udah sampe batasnya -12), nilai direction==1
			direction = 1;
		}else if(gameObject.transform.position.x < startx && direction == 1){ //kalo obj udh kurang dari 0 & direction(udh memenuhi batasan sampe -12), dia akan ke arah positif
			gameObject.transform.position = new Vector2(gameObject.transform.position.x + speed, gameObject.transform.position.y);
		}else if(gameObject.transform.position.x >= startx && direction == 1){ //klo ke arah positifnya udh sama dengan startx(dimana disini nilai startx =0) nilai direction = 0
			direction = 0;
		}
	}
}
