using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class StartGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	public void StartLevel1 (){
		SceneManager.LoadScene ("Level1");
	
	}

	// Update is called once per frame
	void Update () {
	
	}
}
