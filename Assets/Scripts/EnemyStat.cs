using UnityEngine;
using System.Collections;

public class EnemyStat : BaseStat {

	protected int Level { get; set; }		// level of the enemy

	public EnemyStat (int l) : base () {
		Level = l;
	}

	// Initialize property values for a balanced type
	public void initBalanced () {
		Strength += Level;
		updateDefense (Level);
		updateEndur (Level);
		updateSpeed (Level);
	}
	
	// Initialize property values for a tanker, weak power type
	// defense up
	public void initTanker () {
		updateDefense (Level);
	}

	// Initialize property values for a power, slow type
	// strength up
	public void initPower (decimal armPref) {
		Strength += Level;
		updateArmPower (armPref);
	}

	// Initialize property values for a speed, weak type
	// speed, stiffness, spirit up
	public void initSpeedy () {
		updateSpeed (Level);
		updateEndur (Level);
	}

	// Initialize property values for a luck type
	// criticalRate, criticalHit
	public void initLucky (int l) {
		CriticalRate += l / 100M;
		CriticalHit += l / 50M;  
	}

}
