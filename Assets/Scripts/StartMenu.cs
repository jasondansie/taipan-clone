using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour {

	public Button startBT;
	public Toggle mark1;
	public Toggle mark2;
	public InputField Pname;
	Game_Manager _GM;
	GameObject GameManager;


	// Use this for initialization
	void Start () {
		startBT = startBT.GetComponent<Button> ();

		mark1 = mark1.GetComponent<Toggle> ();
		mark2 = mark2.GetComponent<Toggle> ();
		Pname = Pname.GetComponent<InputField> ();


	}

	// Update is called once per frame
	void Update () {
		
	}

	public void startGame(){
		GameManager = GameObject.Find ("GameManager");
		_GM = GameManager.gameObject.GetComponent( typeof(Game_Manager) ) as Game_Manager;

		Debug.Log ("log me");

		_GM.set_PlayerName(Pname.text);
		Debug.Log (_GM.get_PlayerName());

		if (mark1.isOn == true) {
			
			Debug.Log ("Choice is 1");
			_GM.set_StartChoice (1);
			_GM.set_GameState ("start");
			SceneManager.LoadScene(2);
		} 
		else {
			
			Debug.Log ("Choice is 2");
			_GM.set_StartChoice (2);
			_GM.set_GameState ("start");
			SceneManager.LoadScene(2);
		} 
	}
}