using UnityEngine;
using System.Collections;

public class PlayerStat : BaseStat {

	protected int CurrRage { get; set; } 	// Current rage points
	protected int MaxRage { get; set; }		// Maximum rage points

	public PlayerStat () : base(){

		CurrRage = 0;
		MaxRage = 100;
	}


	// Initialize property values for Afri (green one)
	public void initAfri () {
		updateSpeed (4);
		updateEndur (4);
	}
	
	// Initialize property values for Adel (yellow one)
	public void initAdel () {
		Strength = 8;
		updateDefense (2);
	}

}
