using UnityEngine;
using System.Collections;

public class audioControle : MonoBehaviour {

	public GameObject audioOff;
	public GameObject audioOn;

	// Use this for initialization
	void Start () {

		audioOff.SetActive (false);
	
	}
	
	public void desligarAudio (){

		audioOff.SetActive (true);
		audioOn.SetActive (false);

	}

	public void ligarAudio (){

		audioOff.SetActive (false);
		audioOn.SetActive (true);

	}
}
