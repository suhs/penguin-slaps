using UnityEngine;
using System.Collections;

public class PlayerStat : BaseStat {

	private bool _canAttack;			// Indicate whether the object is ready to attack
	private float _cooldownTimeR;		// Cool-down time between attacks for a right arm
	private float _cooldownTimeL;		// Cool-down time between attacks for a left arm
	private int _stiffnessR;			// Number of attacks required to trigger stiffness on a right arm 
	private int _stiffnessL;			// Number of attacks required to trigger stiffness on a left arm 
	
	private int _rage;				// Current rage points
	private int _maxRage;				// Maximum rage points

	public PlayerStat () {
		_canAttack = false;
		_cooldownTimeR = 1.0f;
		_cooldownTimeL = 1.0f;
		_stiffnessR = 3;
		_stiffnessL = 3;

		_rage = 0;
		_maxRage = 100;
	}

	public bool CanAttack {
		get { return _canAttack; }
		set { _canAttack = value; }
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

	public int CurrentRage {
		get { return _rage; }
		set { }
	}

	public int MaxRage {
		get { return _maxRage; }
		set { }
	}
}
