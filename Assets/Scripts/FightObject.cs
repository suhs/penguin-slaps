using UnityEngine;
using System.Collections;

public abstract class FightObject : MonoBehaviour {


	// stats of a character
	public float attackSpeed = 0.8f;		// Delay time between attack moves 
	public float damage = 10.0f;			// Damage each attack can do to opponents
	public float defense = 1.0f;			// Points that can be subtracted from the total damage points
	public float criticalRate = 0.05f;		// Critical hit rate
	public float spirit = 0.01f;			// Probability of surviving after a deadly attack with 1 life point remained

	// attack stats
	private bool canAttack = false;			// Indicate whether the object is ready to attack
	public float cooldownTimeR = 1.0f;		// Cool-down time between attacks for a right arm
	public float cooldownTimeL = 1.0f;		// Cool-down time between attacks for a left arm
	public float armPowerR = 1.0f;			// Right arm power (1 at full strength)
	public float armPowerL = 1.0f;			// Left arm power (1 at full strength)
	public int stiffnessR = 3;				// Number of attacks required to trigger stiffness on a right arm 
	public int stiffnessL = 3;				// Number of attacks required to trigger stiffness on a left arm

	public char armDominance;				// Arm dominance ('R' or 'L')			

	// status during the fight
	public float health = 100.0f;			// Total health points
	public float rage = 0.0f;				// Initial rage points

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
