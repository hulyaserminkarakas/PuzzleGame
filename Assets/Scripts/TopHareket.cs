using UnityEngine;
using System.Collections;

public class TopHareket : MonoBehaviour {
	public GameObject top;
	public float hareketGucu;
	public int atisHakki = 1;
	public enum Hareket{ILERI,GERI};
	public Hareket hareketYonu;
	private GameObject topKopya;
	private float uygulanacakGuc;
	private Vector2 ilkKonum = Vector2.zero;
	private Vector2 sonKonum = Vector2.zero;
	private Vector2 okKonum = Vector2.zero;
	private float mesafe;
	public GameObject sphere ;

	void Start () {
		top.SetActive (false);
		sphere.SetActive (false);
	}

	void Update () {
		if (atisHakki > 0) {
			if (Input.GetMouseButtonDown (0)) {
				Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);    
				ilkKonum = ray.origin + (ray.direction);
				GameObject kopya = (GameObject)Instantiate (top, ilkKonum, top.transform.rotation);
				kopya.SetActive (true);
				topKopya = kopya;
			}
			if (Input.GetMouseButtonUp (0)) {
				sphere.SetActive(false);
				Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);    
				sonKonum = ray.origin + (ray.direction);  
				mesafe = Vector2.Distance (ilkKonum, sonKonum);

				uygulanacakGuc = hareketGucu * mesafe;
				topKopya.GetComponent<Rigidbody> ().AddForce (RdHesapla (ilkKonum, sonKonum) * uygulanacakGuc);
				atisHakki--;
			}
		} else {
			if (Input.GetMouseButtonDown (0)) {
				Application.LoadLevel(Application.loadedLevel);
			}
		}
		if ( Input.GetMouseButton ( 0 ) ) {
			sphere.active=true;
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition); 
			okKonum= ray.origin + (ray.direction);
			if (ilkKonum.x>=okKonum.x)sphere.transform.localScale=new Vector2(Mathf.Sqrt((ilkKonum.x-okKonum.x)*(ilkKonum.x-okKonum.x)/16+(ilkKonum.y-okKonum.y)*(ilkKonum.y-okKonum.y)/16),0.3f);
			if (ilkKonum.x<okKonum.x)sphere.transform.localScale=new Vector2(-1*Mathf.Sqrt((ilkKonum.x-okKonum.x)*(ilkKonum.x-okKonum.x)/16+(ilkKonum.y-okKonum.y)*(ilkKonum.y-okKonum.y)/16),0.3f);
			sphere.transform.position = new Vector2((ilkKonum.x+(ilkKonum.x-okKonum.x)/2),(ilkKonum.y+(ilkKonum.y-okKonum.y)/2));
			if (ilkKonum.x!=okKonum.x) sphere.transform.rotation = Quaternion.Euler(0, 0,57.3f*Mathf.Atan((ilkKonum.y-okKonum.y)/(ilkKonum.x-okKonum.x)));
		}
	}

	Vector3 RdHesapla(Vector2 vektor1, Vector2 vektor2){
		Vector3 Rd = Vector3.zero;
		Rd = vektor2 - vektor1;
		Rd.Normalize ();
		if(hareketYonu == Hareket.GERI){
			Rd *= -1;
		}
		return Rd;
	}
}
