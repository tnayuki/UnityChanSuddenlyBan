using UnityEngine;
using System.Collections;

public class CarController : MonoBehaviour {
	public float speed;

	// Use this for initialization
	void Start () {
		//rigidbody.velocity = Vector3.forward * 100f;
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y < -5) {
			Destroy(this.gameObject);
		}

		transform.position -= new Vector3(speed * Mathf.Sin(transform.eulerAngles.y * Mathf.PI / 180) * Time.deltaTime, 0, speed * Mathf.Cos(transform.eulerAngles.y * Mathf.PI / 180) * Time.deltaTime);
	}
}
