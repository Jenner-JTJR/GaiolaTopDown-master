using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerMove : MonoBehaviour
{
	private Rigidbody2D rb;
	public Joystick joystick; //Joystick virtual da AssetStore
	public float moveSpeed = 5f; //Velocidade de movimento do player
	public Animator animator;

	// Start is called before the first frame update
	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update()
	{
		JoystickMove(); //função que chama a movimentação do player usando o joystick

		Animation(); //função que chama as animações de movimentação do player

		if (CrossPlatformInputManager.GetButtonDown("Fire1"))  
		{
			Debug.Log("Botão Funcionando");
		}
	}

	void JoystickMove()
	{
		if (joystick.Horizontal >= .2f) 
		{
			rb.velocity = (new Vector2(joystick.Horizontal * moveSpeed, joystick.Vertical * moveSpeed));
		}
		else if (joystick.Horizontal <= .2f)
		{
			rb.velocity = (new Vector2(joystick.Horizontal * moveSpeed, joystick.Vertical * moveSpeed));
		}
	}

	void Animation()
	{
		animator.SetFloat("Horizontal", joystick.Horizontal);
		animator.SetFloat("Vertical", joystick.Vertical);
		if (joystick.Horizontal != 0f || joystick.Vertical != 0f)
		{
			animator.SetBool("Moving", true);
		}
		else
		{
			animator.SetBool("Moving", false);
		}
	}
}
