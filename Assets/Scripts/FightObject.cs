using UnityEngine;
using System.Collections;

public abstract class FightObject : MonoBehaviour {

	// Default stats
	public float attackSpeed = 0.8f;		// Delay time between attack moves 
	public float damage = 10.0f;			// Damage each attack can do to opponents
	public float defense = 1.0f;			// Points that can be subtracted from the total damage points
	public float criticalRate = 0.05f;		// Critical hit rate
	public float spirit = 0.01f;			// probability of surviving after a deadly attack with 1 life point remained

	public float health = 100.0f;			// total health points
	public float rage = 0.0f;				// initial rage points

	private SpriteRenderer spriteRenderer;	//Store a component reference to the attached SpriteRenderer.


	// can be overridden by inheriting classes
	protected virtual void Start () {

	}

	protected virtual void attack <T> () where T : Component {


	
	}

	protected virtual void dodge () {

	
	}

	/**
     * Coroutine to create a flash effect when get attacked
     *
     * @param sprite	a sprite renderer
     * @param times  	how many times a sprite flash
     * @param delay     time in between each flash
     */
	
	protected IEnumerator flashObject (SpriteRenderer sprite, int times, float delay) {
		spriteRenderer.enabled = false;
		yield return new WaitForSeconds(delay);
		spriteRenderer.enabled = true;
	}

	// Update is called once per frame
	void Update () {
	
	}
}
