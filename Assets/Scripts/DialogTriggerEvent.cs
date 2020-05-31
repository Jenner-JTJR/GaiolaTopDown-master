using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;
using TMPro;

public class DialogTriggerEvent : MonoBehaviour

{
	public GameObject dialogBox;
	public bool playerInRange;
	public TextMeshProUGUI textDisplay;
	public string[] sentences;
	private int index;
	public float typingSpeed;
	public bool canContinue;
	public GameObject image;
	public GameObject player;
	public PlayerMove playerMove;

	// Start is called before the first frame update
	void Start()
	{

	}

	private void Update()
	{
		if (textDisplay.text == sentences[index])
		{
			canContinue = true;
		}
		DialogInputSystem();
		if (dialogBox && index == sentences.Length - 1)
		{
			dialogBox.SetActive(false);
			image.SetActive(false);
			player.transform.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
			playerMove.playerMove = true;
			Destroy(gameObject);
			//dialogBox.SetActive(false);
			//image.SetActive(false);
			//index = 0;
		}

		

	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.CompareTag("Player"))
		{
			Debug.Log("PlayerInRage");
			playerInRange = true;
			dialogBox.SetActive(false);
		}
	}

	private void OnTriggerExit2D(Collider2D collision)
	{
		if (collision.CompareTag("Player"))
		{
			Debug.Log("PlayerOffRange");
		}

	}


	public void DialogInputSystem()
	{
		if (playerInRange == true)
		{
			if (dialogBox.activeInHierarchy == false)
			{
				player.transform.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
				playerMove.playerMove = false;
				dialogBox.SetActive(true);
				image.SetActive(true);
				StartCoroutine(Type());
			}
			else if (CrossPlatformInputManager.GetButtonDown("Fire1") && index < sentences.Length - 1 && canContinue)
			{
				NextSentence();
			}
		}
		/*else if (dialogBox && index == sentences.Length - 1)
		{
			player.transform.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
			dialogBox.SetActive(false);
			image.SetActive(false);
			index = 0;
		}*/
	}

	IEnumerator Type()
	{
		foreach (char letter in sentences[index].ToCharArray())
		{
			textDisplay.text += letter;
			yield return new WaitForSeconds(typingSpeed);
			canContinue = false;
		}
	}

	public void NextSentence()
	{
		canContinue = false;

		if (index < sentences.Length - 1)
		{
			index++;
			textDisplay.text = "";
			StartCoroutine(Type());
		}
		else
		{
			textDisplay.text = "";
			canContinue = false;
		}
	}

}
