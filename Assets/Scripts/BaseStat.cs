using UnityEngine;
using System.Collections;
using System;

public class BaseStat : MonoBehaviour {

	// properties
	protected int MaxHealth { get; set; }			// Max health points
	protected int CurrHealth { get; set; }			// Current health points
	protected int Strength { get; set; } 			// Damage each attack can do to opponents
	protected int Defense { get; set; }				// Points that can be subtracted from the total damage points
	protected int Endurance { get; set; }			// Endurance (related to)
	protected int Speed { get; set; }				// Speed
	protected decimal CriticalRate { get; set; }	// Critical hit frequency rate
	protected decimal CriticalHit { get; set; }		// Critical hit bonus rate
	protected decimal SurvivalRate { get; set; } 	// Probability of surviving after a deadly attack with 1 life point remained
	
	// Attack-related properties
	public bool CanAttack { get; set; }				// Indicate whether the object is ready to attack
	protected decimal ArmPower { get; set; }		// Arm power (1 if a right arm has full power; -1 if a left arm has full power)
	protected decimal CoolDownTimeR { get; set; }	// Cool-down time between attacks for a right arm
	protected decimal CoolDownTimeL  { get; set; }	// Cool-down time between attacks for a left arm
	protected int StiffnessR { get; set; }			// Number of attacks required to trigger stiffness on a right arm 
	protected int StiffnessL { get; set; }			// Number of attacks required to trigger stiffness on a left arm
	protected int BurnoutCount { get; set; }		// Number of attacks that cause 'burnout'
	protected decimal BurnoutDuration { get; set; }	// Duration an object have to wait to

	// 
	private decimal maxArmp = 1M;
	private decimal minArmp = -1M;

	public BaseStat () {
		MaxHealth = 100;
		CurrHealth = MaxHealth;
		Strength = 5;
		Defense = 1;
		Endurance = 1;
		Speed = 1;

		CriticalRate = 0.01M;
		CriticalHit = 0.3M;

		ArmPower = 0.0M;	// balanced
		CoolDownTimeR = 0.5M;	// note: 1 means fast, 0 means non-moving
		CoolDownTimeL = 0.5M;
		StiffnessR = 3;
		StiffnessL = 3;

		BurnoutCount = 8;
		BurnoutDuration = 3.0M;
		SurvivalRate = 0.05M;

		CanAttack = false;
	}

	// FIXME : nooooob

	// adjust Endurance, BurnoutCount, and SurvivalRate
	public void updateEndur (int newEndur) {
		int diff = Endurance - newEndur; // save the difference
		int ratio = 2;
		Endurance = newEndur;
		SurvivalRate += (decimal)diff / (100 * ratio);
		BurnoutCount += diff / ratio;
	}

	// adjust Speed, Stiffness, CoolDownTimes
	public void updateSpeed (int newSpd) {
		int diff = Speed - newSpd;
		int ratio = 10;
		Speed = newSpd;
		StiffnessL += diff;
		StiffnessR += diff;
		CoolDownTimeL += (decimal)diff / ratio;
		CoolDownTimeR += (decimal)diff / ratio;
	}

	// adjust Defense and MaxHealth 
	public void updateDefense (int newDefns) {
		int diff = Defense - newDefns;
		int ratio = 5;
		Defense = newDefns;
		MaxHealth = diff * ratio;
	}

	// adjust ArmPower and all variables that have R and L 
	public void updateArmPower (decimal newArmp) {
		// get non-weighted default value
		decimal coolDownTime = CoolDownTimeL + CoolDownTimeR;
		int stiffness = StiffnessL + StiffnessR;

		CoolDownTimeR = calculateR (coolDownTime, newArmp);
		CoolDownTimeL = coolDownTime - CoolDownTimeR;
		StiffnessR = (int)calculateR ((decimal)stiffness, newArmp);
		StiffnessL = stiffness - StiffnessR; 
	}
	
	// normalize the sum to ArmPower
	private decimal calculateR (decimal sum, decimal value) {
		decimal norm = (value - minArmp) / (maxArmp - minArmp);
		return norm * sum;
	}
	
}
