using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour {

	public void NextLevel(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
	}

	public void PrevLevel(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex - 1);
	}

	public void QuitGame(){
		Application.Quit ();
	}
}
