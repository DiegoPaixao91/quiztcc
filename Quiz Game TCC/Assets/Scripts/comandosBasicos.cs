using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class comandosBasicos : MonoBehaviour {

	public void carregaCena (string nomeCena){
		SceneManager.LoadScene(nomeCena);

	}

	public void resetarPontuacoes(){

		PlayerPrefs.DeleteAll ();

	}

	public void Sair() {
		
		Application.Quit();

	}
}