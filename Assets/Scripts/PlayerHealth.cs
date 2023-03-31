using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
	PlayerUi playerUI;
	public static event Action OnPlayerDeath;
	public float health=100;
	GameObject Healthy;

	void Start(){
		playerUI = GetComponent<PlayerUi>();
		Healthy = GameObject.Find("Health");
		SetStats ();
	}

	public void DecreaseHealth(float amount)
	{
		health -= amount;
		SetStats ();
		if(health <= 0)
		{	
			health = 0;
			Cursor.lockState = CursorLockMode.None;
			OnPlayerDeath?.Invoke();
			
		}
	}

	 void SetStats()
    {
        playerUI.healthtext.text = health.ToString();
    }

	
	
}
