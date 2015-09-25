using UnityEngine;
using System.Collections;

public class EnemyStat : BaseStat {

	protected int level { get; set; }		// level of the enemy

	// TODO		: add levelUp function
	// UNDONE	: implement all init functions

	// Initialize property values for a balanced type
	public void initBalanced () {
		
	}
	
	// Initialize property values for a tanker, weak power type
	// defense, health, spirit up
	// everything else down, normal speed
	public void initTanker () {
		
	}

	// Initialize property values for a power, slow type
	// strength up
	// everything else down, normal defense
	public void initPower (float armPref) {

	}

	// Initialize property values for a speed, weak type
	// speed, stiffness, spirit up
	// everything else down, normal health
	public void initSpeedy () {

	}

	// Initialize property values for a luck type
	// criticalRate, criticalHit, speed, stiffnes, spirit up
	// everything else significantly down
	public void initLucky () {

	}

}
