using UnityEngine;
using System.Collections;

public class Trade : MonoBehaviour {

	int Opium = 0;
	int Silk = 0;
	int Arms = 0;
	int General = 0;
	public string OpiumText = "";
	public string SilkText = "";
	public string ArmsText = "";
	public string GeneralText = "";
	public string greet = "Taipan, present prices per unit here are \n\n";


	int GetRandom(int min, int max){

		int Rand = Random.Range (min, max);
		return Rand;
	}

	public void LoadNewTrade(){

		this.Opium = GetRandom (5000, 38000);
		this.Silk = GetRandom (400, 2600);
		this.Arms = GetRandom (50, 500);
		this.General = GetRandom (1, 25);

		OpiumText = "\tOpiúm: " + this.Opium.ToString() + "\t\t\t";
		SilkText = " Silk: " + this.Silk.ToString() + "\n";
		ArmsText = "\tArms: " + this.Arms.ToString() + "\t\t\t\t";
		GeneralText = " General: " + this.General.ToString()  + "\n";
	}

	public void LoadCurrentTrade(){
		OpiumText = "\tOpiúm: " + this.Opium.ToString() + "\t\t\t";
		SilkText = " Silk: " + this.Silk.ToString() + "\n";
		ArmsText = "\tArms: " + this.Arms.ToString() + "\t\t\t\t";
		GeneralText = " General: " + this.General.ToString()  + "\n";
	}
	public int get_General(){

		return this.General;
	}
	public int get_Arms(){

		return this.Arms;
	}
	public int get_Silk(){

		return this.Silk;
	}
	public int get_Opium(){

		return this.Opium;
	}
}