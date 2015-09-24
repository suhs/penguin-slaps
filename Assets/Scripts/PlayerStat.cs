using UnityEngine;
using System.Collections;

public class PlayerStat : BaseStat {

	private int _rage;					// Current rage points
	private int _maxRage;				// Maximum rage points

	public PlayerStat () {

		_rage = 0;
		_maxRage = 100;

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
