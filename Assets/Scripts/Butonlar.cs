using UnityEngine;
using System.Collections;

public class Butonlar : MonoBehaviour {

	public void Basla(){
		Application.LoadLevel (Application.loadedLevel + 1);
	}

	public void Cikis(){
		Application.Quit();
	}

}
