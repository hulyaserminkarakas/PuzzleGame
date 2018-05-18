using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BolumText : MonoBehaviour {
	void Start () {
		GetComponent<Text> ().fontSize = 0;
		GetComponent<Text>().text = Application.loadedLevel.ToString();
	}
	void FixedUpdate(){
		if (GetComponent<Text> ().fontSize <= 200) {
			GetComponent<Text> ().fontSize += 4;
		} 
		else {
			Destroy(this.gameObject);
		}
	}
}
