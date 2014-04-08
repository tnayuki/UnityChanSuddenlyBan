using UnityEngine;
using System.Collections;

public class SuddenlyBan : MonoBehaviour
{
		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
				if (Time.timeSinceLevelLoad > 1.0f) {
						Application.LoadLevel ("Game");
				}

				if (Time.timeSinceLevelLoad > 0.5f) {
						GameObject banner = GameObject.Find ("Banner");
						banner.transform.position = new Vector3 (banner.transform.position.x, banner.transform.position.y, 5);
				} 
		}
}
