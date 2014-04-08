using UnityEngine;
using System;
using System.Collections;

public class Timer : MonoBehaviour
{
		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
				guiText.text = String.Format ("{0:0}:{1:00}", Math.Floor (Time.timeSinceLevelLoad), Time.timeSinceLevelLoad % 1 * 100);
		}
}
