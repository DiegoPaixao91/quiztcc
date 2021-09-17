using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class comandoOpcao : MonoBehaviour {

	public GameObject opcaoOn;
	public GameObject opcaoOff;


	// Use this for initialization
	void Start () {

		opcaoOn.SetActive (true);
		opcaoOff.SetActive (false);

	}
	
	public void carregarOpacao (){

		opcaoOn.SetActive (false);
		opcaoOff.SetActive (true);

				
	}

	public void descarregarOpacao (){

		opcaoOff.SetActive (false);
		opcaoOn.SetActive (true);


	}

			
}
