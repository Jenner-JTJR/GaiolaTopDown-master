using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;

public class Door : MonoBehaviour
{
	public SpriteRenderer doorSprite;
	public BoxCollider2D doorCollider;
	public Inventory inventory;
	public bool playerInRange;
	public DialogTest dialog;
	public PlayerMove player;
	public AudioSource AbrindoP;

    void Start()
    {
		
    }

    void Update()
    {
		OpenDoor();
    }

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.CompareTag("Player"))
		{
			playerInRange = true;
		}
	}

	private void OnTriggerExit2D(Collider2D collision)
	{
		playerInRange = false;
	}

	public void OpenDoor()
	{
		if (inventory.rustedKey == gameObject.tag)
		{
			AbrindoP.Play();
			gameObject.GetComponent<DialogTest>().enabled = false;
			dialog.image.SetActive(false);
			if (CrossPlatformInputManager.GetButtonDown("Fire1") && playerInRange)
			{
				//doorCollider.enabled = false;
				//doorSprite.enabled = false;
				player.playerMove = true;
				Destroy(gameObject);
				dialog.dialogBox.SetActive(false);
			}

		}
		if (inventory.goldenKey == gameObject.tag && CrossPlatformInputManager.GetButtonDown("Fire1"))
		{
			gameObject.GetComponent<DialogTest>().enabled = false;
			doorSprite.enabled = false;
			doorCollider.enabled = false;
		}
	}
}
