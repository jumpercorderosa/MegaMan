using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class Blink : MonoBehaviour {

	public float intervalo;

	// Use this for initialization
	IEnumerator Start () {

		//Obtem o componente do objeto
		GetComponent<SpriteRenderer> ().enabled = false;
		yield return new WaitForSeconds (intervalo);
		GetComponent<SpriteRenderer> ().enabled = true;
		yield return new WaitForSeconds (intervalo);

		//Faz a chamada novamente do metodo deixando em looing
		StartCoroutine(Start());
		
	}

	void Update() {

		//Pressionar enter
		if(Input.GetKeyDown(KeyCode.Return)) {
			SceneManager.LoadScene ("game-scene");

		}
	}
}
