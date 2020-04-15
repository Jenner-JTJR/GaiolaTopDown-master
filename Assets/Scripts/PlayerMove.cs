using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
	private Rigidbody2D rb;
	public Joystick joystick;
	public float moveSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
		rb = GetComponent<Rigidbody2D>();
	}

    // Update is called once per frame
    void Update()
    {
		JoystickMove();
    }

	void JoystickMove()
	{
		if (joystick.Horizontal >= .2f)
		{
			rb.velocity = (new Vector2(joystick.Horizontal * moveSpeed * Time.deltaTime, joystick.Vertical * moveSpeed * Time.deltaTime));
		}
		else if (joystick.Horizontal <= .2f)
		{
			rb.velocity = (new Vector2(joystick.Horizontal * moveSpeed * Time.deltaTime, joystick.Vertical * moveSpeed * Time.deltaTime));
		}
	}

}
