using UnityEngine;
using System.Collections;

public abstract class FightObject : MonoBehaviour {
	
	private SpriteRenderer spriteRenderer;	// Store a component reference to the attached SpriteRenderer.

	// opponent components
	public GameObject opponent;				// Reference to an opponent
	private string opponentTag;				// Tag name of an opponent


	// can be overridden by inheriting classes
	protected virtual void Start () {
		// inheriting class should assign opponentTag here
		// find an opponent object
		opponent = GameObject.FindWithTag (opponentTag);
		// get a reference to the SpriteRenderer component
		spriteRenderer = gameObject.GetComponent<SpriteRenderer>(); 


	}

	protected virtual void attack () {


	
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
		for (int i = 0; i < times; i++) {
			yield return new WaitForSeconds (delay);
			spriteRenderer.enabled = false;
			yield return new WaitForSeconds (delay);
			spriteRenderer.enabled = true;
		}
	}

	// Update is called once per frame
	void Update () {
	
	}
}
