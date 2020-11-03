using UnityEngine;
using System.Collections;

public class Game_Manager : MonoBehaviour {

	static Game_Manager Instance;
	int StartChoice;
	string PlayerName;
	string GameState;
	int CargoChoice;

	// Use this for initialization
	void Start () {
		if (Instance != null) {
			GameObject.Destroy (gameObject);
		} 
		else {
			GameObject.DontDestroyOnLoad (gameObject);
			Instance = this;
		}

	}

	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyUp(KeyCode.Escape))
		{
			if (Application.platform == RuntimePlatform.Android)
			{
				AndroidJavaObject activity = new AndroidJavaClass("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaObject>("currentActivity");
				activity.Call<bool>("moveTaskToBack", true);
			}
			else
			{
				Application.Quit();
			}
		}
	}

	public void set_PlayerName(string name){
		PlayerName = name;
	}
	public string get_PlayerName(){
		return PlayerName;
	}
	public void set_StartChoice(int num){
		StartChoice = num;
	}
	public int get_StartChoice(){
		return StartChoice;
	}
	public void set_GameState(string st){
		GameState = st;
	}
	public string get_GameState(){
		return GameState;
	}
	public void set_CargoChoice(int ch){
		CargoChoice = ch;
	}
	public int get_CargoChoice(){
		return CargoChoice;
	}
}