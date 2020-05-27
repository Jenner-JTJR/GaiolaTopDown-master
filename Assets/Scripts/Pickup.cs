using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{

	public Inventory inventory;
	public GameObject itemButton;

	// Start is called before the first frame update
	void Start()
    {
		inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.CompareTag("Player"))
		{
			for (int i = 0; i < inventory.slots.Length; i++)
			{
				if (inventory.isFull[i] == false)
				{
					inventory.isFull[i] = true;
					Instantiate(itemButton, inventory.slots[i].transform, false);
					GetKeyItem();
					Destroy(gameObject);
					break;
				}
			}
		}
	}

	public void GetKeyItem()
	{
		if(gameObject.tag == "RustedKey")
		{
			inventory.rustedKey = "RustedDoor";
		}
		if(gameObject.tag == "GoldenKey")
		{
			inventory.goldenKey = "GoldenDoor";
		}
	}


}
