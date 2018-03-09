using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TheSceneManager : MonoBehaviour {

	public void NextScene(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
	}

	public void ToWorldScene(){
		SceneManager.LoadScene ("World");
	}

	public void PrevScene(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex - 1);
	}

	public void ExitGame(){
		Application.Quit ();
	}
}
