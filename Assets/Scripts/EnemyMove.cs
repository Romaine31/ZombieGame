using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour
{
	public NavMeshAgent enemy;
	Transform Player;
	void Start()
	{
		Player = GameObject.Find("Player").transform;
	}
	
	void Update()
	{
		float dist = Vector3.Distance(transform.position, Player.position);
		float stoppingDistance = 2;
		
		if(dist<stoppingDistance)
		{
			StopTargeting();
		}
		else
		{
			StartTargeting();
		}
		
	}
	
	private void StartTargeting()
	{
		enemy.isStopped = false;
		enemy.SetDestination(Player.position);
	}
	
	private void StopTargeting()
	{
		enemy.isStopped = true;
	}
	
}
