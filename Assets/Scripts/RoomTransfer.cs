using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomTransfer : MonoBehaviour
{

	public Vector2 cameraChangeMax;
	public Vector2 cameraChangeMin;
	public Vector3 playerChange;
	private CameraMove cam; 

    // Start is called before the first frame update
    void Start()
    {
		cam = Camera.main.GetComponent<CameraMove>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.CompareTag("Player"))
		{
			cam.minPosition = cameraChangeMin;
			cam.maxPosition = cameraChangeMax;
			collision.transform.position += playerChange;
		}
	}
}
