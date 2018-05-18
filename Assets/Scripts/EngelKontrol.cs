using UnityEngine;
using System.Collections;

public class EngelKontrol : MonoBehaviour {

	public GameObject[] engeller;
	private int engelSayac = 0;

	void Update(){
		for(int i = 0; i < engeller.Length;i++){
			if(engeller[i] != null){
				engelSayac++;
			}
		}
		if(engelSayac <= 0){
			Application.LoadLevel(Application.loadedLevel + 1);
		}
		else{
			engelSayac = 0;
		}
	}
}
