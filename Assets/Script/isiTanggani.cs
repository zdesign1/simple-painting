using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isiTanggani : MonoBehaviour {

	public Kuas kuas;
	private Vector3 posisi;

	public int warna;

	void Start ()
{
}

	void Update ()
		{
		posisi = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		posisi.z = -5;
		if (Input.GetMouseButtonDown (0)){
			raycast2d ();
		}

		if (kuas != null)
			kuas.transform.position = posisi;
		}

private void raycast2d ()
		{
			RaycastHit2D rayCastHit2D = Physics2D.Raycast (posisi, Vector2.zero);
			
			if (rayCastHit2D.collider == null){
			return;
			}

			if (rayCastHit2D.collider.tag == "warnaKuas"){
			
			kuas.warna = rayCastHit2D.collider.GetComponent<warnaKuas> ().value;
			kuas.transform.GetChild(0).GetComponent<SpriteRenderer>().color = kuas.warna;
			} else if (
				rayCastHit2D.collider.tag == "bagian")
				{

			rayCastHit2D.collider.GetComponent<SpriteRenderer> ().color = kuas.warna;
		}
	}
}