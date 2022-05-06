using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public float speed;
	public Rigidbody rb;
	private int score;
	// Start is called before the first frame update
	void Start()
	{
		speed = 800f;
		score = 0;
	}

	// Update is called once per frame
	void FixedUpdate()
	{
		if (Input.GetKey("d"))
		{
			rb.AddForce(speed * Time.deltaTime, 0, 0);
		}
		if (Input.GetKey("a"))
		{
			rb.AddForce(-speed * Time.deltaTime, 0, 0);
		}
		if (Input.GetKey("w"))
		{
			rb.AddForce(0, 0, speed * Time.deltaTime);
		}
		if (Input.GetKey("s"))
		{
			rb.AddForce(0, 0, -speed * Time.deltaTime);
		}
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Pickup")
		{
			score++;
			Debug.Log($"Score:{score}");
			other.gameObject.SetActive(false);
		}
	}
}
