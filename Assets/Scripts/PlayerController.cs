using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	
	// TODO: Make them dynamic
	public float playerCentreLBound = -1.5f;	// left bound of the centre of the body
	public float playerCentreRBound = 1.5f;		// right bound of the centre of the body

	private Animator animator;					// a reference to the player's animator component


	// Use this for initialization
	void Start () {

		animator = GetComponent<Animator> ();

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseUp(){
		
		Vector3 mouseWorldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		Vector2 playerToMouse = mouseWorldPoint - transform.position;
		
		if (playerToMouse.x > playerCentreRBound) {
			animator.SetTrigger("playerRSlap");
			Debug.Log("Right!");
		} else if (playerToMouse.x < playerCentreLBound) {
			animator.SetTrigger("playerLSlap");
			Debug.Log("Left!");
		} else {
			Debug.Log("Centre!");
		}
		
	}
}
