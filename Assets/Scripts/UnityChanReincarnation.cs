using UnityEngine;
using System.Collections;

public class UnityChanReincarnation : MonoBehaviour
{
		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
				if (transform.position.y < -5) {
						Application.LoadLevel ("Game");
				}
		}
}
