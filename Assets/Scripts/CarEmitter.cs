using UnityEngine;
using System.Collections;

public class CarEmitter : MonoBehaviour
{
		public GameObject prefab;

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
				if (GameObject.FindGameObjectsWithTag ("Enemy").Length < Time.timeSinceLevelLoad) {

						GameObject newCar = (GameObject)Instantiate (prefab);

						newCar.transform.position = new Vector3 (Random.Range (-40, 40), 0.8f, Random.Range (-40, 40));
						newCar.transform.rotation = Quaternion.LookRotation (newCar.transform.position - GameObject.FindGameObjectWithTag ("Player").transform.position);
				}
		}
}
