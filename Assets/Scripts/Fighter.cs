using UnityEngine;
using System.Collections;

public class Fighter : MonoBehaviour {

	public BaseStat charStat;
	public GameObject healthBar;		// health bar
	public Animator animator;			// a reference to the player's animator component
	
	public GameObject opponent;			// opponent reference
	
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void updateHealthBar (float h) {
		healthBar.transform.localScale = new Vector3 (Mathf.Clamp (h,0f,1f),
		                                              healthBar.transform.localScale.y, healthBar.transform.localScale.z);
	}

}
