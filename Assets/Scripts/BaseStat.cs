using UnityEngine;
using System.Collections;

public class BaseStat : MonoBehaviour {
	
	private int _health;			// Total health points

	private float _attackSpeed;		// Delay time between attack moves 
	private int _strength;			// Damage each attack can do to opponents
	private int _defense;			// Points that can be subtracted from the total damage points
	private float _criticalRate;	// Critical hit rate
	private float _spirit;			// Probability of surviving after a deadly attack with 1 life point remained
	private float _armPower;		// Arm power (1 if a right arm has full power; -1 if a left arm has full power)

	public BaseStat () {
		_health = 100;
		
		_attackSpeed = 0.8f;
		_strength = 10;
		_defense = 1;
		_criticalRate = 0.05f;
		_spirit = 0.01f;
		_armPower = 0.0f;	// balanced
	}

	public int Health {
		get { return _health; }
		set { _health = value; }
	}

	public float AttackSpeed {
		get { return _attackSpeed; }
		set { _attackSpeed = value; }
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

	public float ArmPower {
		get { return _armPower; }
		set { _armPower = value; }
	}
	
}
