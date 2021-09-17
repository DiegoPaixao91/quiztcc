using UnityEngine;
using System.Collections;

public class comandoReset : MonoBehaviour {

	public GameObject painelReset;
	public GameObject painelSobre;
	public GameObject opcaoOn;
	public GameObject opcaoOff;
	public GameObject btnPlay;

	// Use this for initialization
	void Start () {

		painelReset.SetActive (false);
		painelSobre.SetActive (false);
			
	}
	
	public void ativarReset(){

		painelReset.SetActive (true);
		opcaoOff.SetActive (false);
		btnPlay.SetActive (false);
	}

	public void desativarReset(){

		painelReset.SetActive (false);
		opcaoOff.SetActive (true);
		btnPlay.SetActive (true);

	}

	public void ativarSobre(){

		painelSobre.SetActive (true);
		opcaoOff.SetActive (false);
		btnPlay.SetActive (false);
	}

	public void desativarSobre(){

		painelSobre.SetActive (false);
		opcaoOff.SetActive (true);
		btnPlay.SetActive (true);

	}
}
