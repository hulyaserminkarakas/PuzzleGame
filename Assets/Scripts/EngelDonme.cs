using UnityEngine;
using System.Collections;

public class EngelDonme : MonoBehaviour {
	public float donmeHizi = 1f;
	void FixedUpdate () {
		transform.Rotate (0,0,donmeHizi);
	}
}
