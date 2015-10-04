using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	// TODO: Add (int) id, (string) name for each enemy in EnemyStat
	// 		change prefab names to corresponding id
	//		then polish this section

	// Enemy01 related
	private string _E01Name = "Enemy01";
	// Enemt02 related
	private string _E02Name = "Enemy02";

	private EnemyStat _enemyStat;		// set default stats

	public GameObject healthBar;		// health bar
	public Animator animator;			// a reference to the player's animator component
	
	public GameObject opponent;			// enemy reference
	
	// Use this for initialization
	void Start () {
		
		_enemyStat = gameObject.AddComponent ("EnemyStat") as EnemyStat;
		opponent = GameObject.FindGameObjectWithTag("Player");

		// Temporary level; A character level should be the same as a stage level
		_enemyStat.setLevel (2);

		if (this.gameObject.name == _E01Name) { // enemy01
			_enemyStat.initBalanced ();
			//healthBar.renderer.material.color = adelColor;
		} else if (this.gameObject.name == _E02Name) { // enemy02
			_enemyStat.initTanker ();
			//healthBar.renderer.material.color = afriColor;
		} else { // unknown player character
			Debug.LogError (gameObject.name);
		}

		animator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void updateHealthBar (float h) {
		healthBar.transform.localScale = new Vector3 (Mathf.Clamp (h,0f,1f),
		                                              healthBar.transform.localScale.y, healthBar.transform.localScale.z);
	}
	
	public void attack () {

		float hPercent = (float)_enemyStat.CurrHealth / _enemyStat.getMaxHealth ();

	}

	public void damaged () {

	}
}
