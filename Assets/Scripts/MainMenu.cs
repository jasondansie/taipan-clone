using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

	public Button startBT;


	// Use this for initialization
	void Start () {
		startBT = startBT.GetComponent<Button> ();
	}
	
	// Update is called once per frame
	void Update () {

	}
	public void startGame(){
		SceneManager.LoadScene(1);

	}				
}