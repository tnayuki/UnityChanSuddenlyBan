using UnityEngine;
using System.Collections;

public class UnityChanBan : MonoBehaviour
{
		// Use this for initialization
		void Start ()
		{
		}
	
		// Update is called once per frame
		void Update ()
		{
		}

		void OnCollisionEnter (Collision collision)
		{
				if (collision.gameObject.CompareTag ("Enemy")) {
						collision.gameObject.collider.isTrigger = true;

						GameObject.Find ("Exploder").SendMessage ("Explode");
						Time.timeScale = 0.3f;

						Invoke ("SuddenlyBan", 0.7f);
				}
		}

		void SuddenlyBan ()
		{
				Time.timeScale = 1.0f;
				Application.LoadLevel ("SuddenlyBan");
		}
}
