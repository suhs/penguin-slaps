using UnityEngine;
using System.Collections;

public class BaseStat : MonoBehaviour {

	// properties
	protected int MaxHealth { get; set; }			// Max health points
	protected int CurrHealth { get; set; }			// Current health points
	protected float Speed { get; set; }				// Delay time between attack moves
	protected int Strength { get; set; } 			// Damage each attack can do to opponents
	protected int Defense { get; set; }				// Points that can be subtracted from the total damage points
	protected float CriticalRate { get; set; }		// Critical hit frequency rate
	protected float CriticalHit { get; set; }			// Critical hit bonus rate
	protected float Spirit { get; set; } 			// Probability of surviving after a deadly attack with 1 life point remained
	
	// Attack-related properties
	protected bool CanAttack { get; set; }			// Indicate whether the object is ready to attack
	protected float ArmPower { get; set; }				// Arm power (1 if a right arm has full power; -1 if a left arm has full power)
	protected float CoolDownTimeR { get; set; }			// Cool-down time between attacks for a right arm
	protected float CoolDownTimeL  { get; set; }			// Cool-down time between attacks for a left arm
	protected int StiffnessR { get; set; }				// Number of attacks required to trigger stiffness on a right arm 
	protected int StiffnessL { get; set; }				// Number of attacks required to trigger stiffness on a left arm
	protected int BurnoutCount { get; set; }		// Number of attacks that cause 'burnout'
	protected float BurnoutDuration { get; set; }	// Duration an object have to wait to

	public BaseStat () {
		MaxHealth = 100;
		CurrHealth = MaxHealth;
		Speed = 0.8f;
		Strength = 10;
		Defense = 1;
		CriticalRate = 0.05f;
		CriticalHit = 0.5f;
		Spirit = 0.01f;

		ArmPower = 0.0f;	// balanced
		CoolDownTimeR = 0.4f;
		CoolDownTimeL = 0.4f;
		StiffnessR = 3;
		StiffnessL = 3;

		BurnoutCount = 20;
		BurnoutDuration = 3.0f;

		CanAttack = false;
	}

	// change the Speed value and adjust CoolDownTime according to the new value
	// UNDONE : should update CoolDownTime as well
	public void updateSpeed (float newSpeed){
		Speed = newSpeed;

	}

	// TODO : add updateSpirit, updateArmpower functions
	//		: add other relationships between properties

}
