using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
	public Rigidbody2D rb;
	public float speed;
	private Waypoints Wpoints;
	private int waypointIndex;
	public float enemyWaitTime;
	public bool canContinue;
	public bool teste;
	public Animator animator;
	private Vector2 direction;
	public Vector2 directionNew;
	public Vector2 directionNow;

    // Start is called before the first frame update
    void Start()
    {
		Wpoints = GameObject.FindGameObjectWithTag("Waypoints").GetComponent<Waypoints>();
    }

    // Update is called once per frame
    void Update()
    {
		EnemyPatrol();
		Animation();
    }

	IEnumerator WaitToContinue()
	{
		yield return new WaitForSeconds(enemyWaitTime);
		canContinue = true;
	}

	public void EnemyPatrol()
	{
		directionNow = transform.position;
		transform.position = Vector2.MoveTowards(transform.position, Wpoints.waypoints[waypointIndex].position, speed * Time.deltaTime);
		directionNew = transform.position;
		direction = (directionNew - directionNow).normalized;
		if (Vector2.Distance(transform.position, Wpoints.waypoints[waypointIndex].position) < 0.1f)
		{
			StartCoroutine(WaitToContinue());

			if (canContinue)
			{
				waypointIndex++;
				teste = false;
			}
		}
		else
		{
			canContinue = false;
		}
		if (waypointIndex == 4)
		{
			waypointIndex = 0;
		}
			
	}

	void Animation()
	{
		animator.SetFloat("Horizontal", direction.x) ;
		animator.SetFloat("Vertical", direction.y);
		if(direction.x != 0 && direction.y != 0)
		{
			animator.SetBool("Moving", true);
		}
		else
		{
			animator.SetBool("Moving", false);
		}
	}

}
