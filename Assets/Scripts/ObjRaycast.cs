using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjRaycast : MonoBehaviour
{
	public float distance;
	public float rotationSpeed;
	public GameObject death;
	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);

		RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.right, distance);
		if (hitInfo.collider != null)
		{
			Debug.DrawLine(transform.position, hitInfo.point, Color.red);
			Debug.Log("Acertou a parede");
			if (hitInfo.collider.CompareTag("Player"))
			{
				Debug.Log("Player");
				death.SetActive(true);
			}
		}
		else
		{
			Debug.DrawLine(transform.position, transform.position + transform.right * distance, Color.green);
		}
	}
}
