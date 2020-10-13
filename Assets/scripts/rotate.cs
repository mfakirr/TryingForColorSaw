using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
	private void FixedUpdate()
	{

		transform.Rotate(0f,700 * Time.deltaTime, 0f);
	}
	private void OnTriggerEnter(Collider other)
	{
		var cubes = other.GetComponent<forcube>();
		if (cubes)
		{
			cubes.destroycubes();
		}
	}
}
