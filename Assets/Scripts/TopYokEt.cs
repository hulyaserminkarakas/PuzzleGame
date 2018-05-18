using UnityEngine;
using System.Collections;

public class TopYokEt : MonoBehaviour {
	public GameObject top;
	void OnTriggerEnter(Collider nesne){
		if(nesne.gameObject.name == "Top(Clone)"){
			Destroy(nesne.gameObject);
			Application.LoadLevel(Application.loadedLevel);
		}
	}
}
