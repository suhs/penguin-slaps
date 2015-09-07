using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	// TODO: Make them dynamic
	public float playerCentreLBound = -1.5f;
	public float playerCentreRBound = 1.5f;

	void OnMouseUp(){

		Vector3 mouseWorldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		Vector2 playerToMouse = mouseWorldPoint - transform.position;

		if (playerToMouse.x > playerCentreRBound) {
			Debug.Log("Right!");
		} else if (playerToMouse.x < playerCentreLBound) {
			Debug.Log("Left!");
		} else {
			Debug.Log("Centre!");
		}

	}
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
