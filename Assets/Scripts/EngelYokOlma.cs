using UnityEngine;
using System.Collections;

public class EngelYokOlma : MonoBehaviour {
	public int carpmaSayisi = 1;

	void OnTriggerEnter(Collider nesne){
		if(nesne.gameObject.name == "Top(Clone)"){
			carpmaSayisi--;
			if(carpmaSayisi <= 0){
				Destroy(this.gameObject,0.1f);
			}
		}
	}
}
