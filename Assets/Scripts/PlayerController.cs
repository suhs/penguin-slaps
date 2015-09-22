using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	// TODO: Make them dynamic
	public float playerCentreLBound;	// left bound of the centre of the body
	public float playerCentreRBound;	// right bound of the centre of the body
	public float playerDodgeAmount;		// how much a player move when dodge 

	private Animator animator;			// a reference to the player's animator component


	// Use this for initialization
	void Start () {

		animator = GetComponent<Animator> ();

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown() {
		// get the position with respect to the pivot
		Vector3 mouseWorldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		Vector2 playerToMouse = mouseWorldPoint - transform.position;				

		if (playerToMouse.x >= playerCentreLBound && playerToMouse.x <= playerCentreRBound) {
			// clicked body; dodge attack while dragging
			animator.SetTrigger("playerDodge");
			transform.position += Vector3.down * playerDodgeAmount;
			Debug.Log ("Centre!");
		}
	}

	void OnMouseUp(){
		
		Vector3 mouseWorldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		// get the position with respect to the pivot
		Vector2 playerToMouse = mouseWorldPoint - transform.position;


		if (playerToMouse.x > playerCentreRBound) {
			// clicked right wing; slap with a right wing
			animator.SetTrigger("playerRSlap");
		} else if (playerToMouse.x < playerCentreLBound) {
			// clicked left wing; slap with a left wing
			animator.SetTrigger("playerLSlap");
		} else {
			// clicked body; go back and idle
			animator.SetTrigger("playerIdle");
			transform.position += Vector3.up * playerDodgeAmount;
		}
		
	}


}
