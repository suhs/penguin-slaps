using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	
	// TODO: Make them dynamic
	public float playerCentreLBound;	// left bound of the centre of the body
	public float playerCentreRBound;	// right bound of the centre of the body
	public float playerDodgeAmount;

	private Animator animator;			// a reference to the player's animator component


	// Use this for initialization
	void Start () {

		animator = GetComponent<Animator> ();

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown() {

		Vector3 mouseWorldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		Vector2 playerToMouse = mouseWorldPoint - transform.position;				// get the position with respect to the pivot

		if (playerToMouse.x >= playerCentreLBound && playerToMouse.x <= playerCentreRBound) {
			animator.SetTrigger("playerDodge");
			transform.position += Vector3.down * playerDodgeAmount;
			Debug.Log ("Centre!");
		}
	}

	void OnMouseUp(){
		
		Vector3 mouseWorldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		Vector2 playerToMouse = mouseWorldPoint - transform.position;				// get the position with respect to the pivot
		
		if (playerToMouse.x > playerCentreRBound) {
			animator.SetTrigger("playerRSlap");
		} else if (playerToMouse.x < playerCentreLBound) {
			animator.SetTrigger("playerLSlap");
		} else {
			animator.SetTrigger("playerIdle");
			transform.position += Vector3.up * playerDodgeAmount;
		}
		
	}


}
