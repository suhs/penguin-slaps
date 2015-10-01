using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	// Adel related
	private string _adelName = "PenguinY";
	Color adelColor = new Color (194,134,36);

	// Afri related
	private string _afriName = "PenguinG";
	Color afriColor = new Color (36,194,134);


	private PlayerStat _playerStat;		// set default stats

	// TODO: Make them dynamic
	public float playerCentreLBound;	// left bound of the centre of the body
	public float playerCentreRBound;	// right bound of the centre of the body
	public float playerDodgeAmount;		// how much a player move when dodge 
	public GameObject healthBar;		// health bar
	public Animator animator;			// a reference to the player's animator component


	// Use this for initialization
	void Start () {

		_playerStat = gameObject.AddComponent ("PlayerStat") as PlayerStat;

		if (this.gameObject.name == _adelName) { // character is Adel
			_playerStat.initAdel ();
			//healthBar.renderer.material.color = adelColor;
		} else if (this.gameObject.name == _afriName) { // character is Afri
			_playerStat.initAfri ();
			//healthBar.renderer.material.color = afriColor;
		} else { // unknown player character
			Debug.LogError (gameObject.name);
		}

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

	public void updateHealthBar (float h) {
		healthBar.transform.localScale = new Vector3 (Mathf.Clamp (h,0f,1f),
		          healthBar.transform.localScale.y, healthBar.transform.localScale.z);
	}

	public void attack () {
		_playerStat.CurrHealth -= 10;
		float hPercent = (float)_playerStat.CurrHealth / _playerStat.getMaxHealth ();
		updateHealthBar (hPercent);
	}
}
