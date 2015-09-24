using UnityEngine;
using System.Collections;

public class BaseStat : MonoBehaviour {
	
	private int _health;			// Total health points

	private float _speed;		// Delay time between attack moves 
	private int _strength;			// Damage each attack can do to opponents
	private int _defense;			// Points that can be subtracted from the total damage points
	private float _criticalRate;	// Critical hit rate
	private float _spirit;			// Probability of surviving after a deadly attack with 1 life point remained

	private bool _canAttack;		// Indicate whether the object is ready to attack
	private float _armPower;		// Arm power (1 if a right arm has full power; -1 if a left arm has full power)
	private float _cooldownTimeR;	// Cool-down time between attacks for a right arm
	private float _cooldownTimeL;	// Cool-down time between attacks for a left arm
	private int _stiffnessR;		// Number of attacks required to trigger stiffness on a right arm 
	private int _stiffnessL;		// Number of attacks required to trigger stiffness on a left arm 

	private int _burnoutCount;		// Number of attacks that cause 'burnout'
	private float _burnoutDuration;	// Duration an object have to wait to 

	public BaseStat () {
		_health = 100;
		_canAttack = false;
		
		_speed = 0.8f;
		_strength = 10;
		_defense = 1;
		_criticalRate = 0.05f;
		_spirit = 0.01f;

		_armPower = 0.0f;	// balanced
		_cooldownTimeR = 1.0f;
		_cooldownTimeL = 1.0f;
		_stiffnessR = 3;
		_stiffnessL = 3;


	}
	

	public int Health {
		get { return _health; }
		set { _health = value; }
	}

	public float Speed {
		get { return _speed; }
		set { _speed = value; }
	}

	public int Strength {
		get { return _strength; }
		set { _strength = value; }
	}

	public int Defense {
		get { return _defense; }
		set { _defense = value; }
	}

	public float CriticalHit {
		get { return _criticalRate; }
		set { _criticalRate = value; }
	}

	public float Spirit {
		get { return _spirit; }
		set { _spirit = value; }
	}

	// Attack-related auto property

	public bool CanAttack {
		get { return _canAttack; }
		set { _canAttack = value; }
	}

	public float ArmPower {
		get { return _armPower; }
		set { _armPower = value; }
	}

	public float CoolDownTimeR {
		get { return _cooldownTimeR; }
		set { }
	}
	
	public float CoolDownTimeL {
		get { return _cooldownTimeL; }
		set { }
	}
	
	public int StiffnessR {
		get { return _stiffnessR; }
		set { }
	}
	
	public int StiffnessL {
		get { return _stiffnessL; }
		set { }
	}

}
