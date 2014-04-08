using UnityEngine;
using System.Collections;

public class UnityChanLicense : MonoBehaviour
{
		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
				if (Time.timeSinceLevelLoad > 2.0f) {
						Application.LoadLevel ("Game");
				}
		}
}
