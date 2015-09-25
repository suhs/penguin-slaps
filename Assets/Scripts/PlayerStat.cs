using UnityEngine;
using System.Collections;

public class PlayerStat : BaseStat {

	protected int CurrRage { get; set; } 	// Current rage points
	protected int MaxRage { get; set; }		// Maximum rage points

	public PlayerStat () {

		CurrRage = 0;
		MaxRage = 100;
	}


	// UNDONE : init functions 
	// Initialize property values for Afri (green one)
	public void initAfri () {
		
	}
	
	// Initialize property values for Adel (yellow one)
	public void initAdel () {
		
	}

}
