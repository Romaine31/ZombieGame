using UnityEngine;

public class EnemyOne : MonoBehaviour
{
	public float health = 40f;
	private float damage = 20f;
	public EnemyMove EnemyAI;
	public PlayerHealth PlayerHP;
	public UnityEngine.AI.NavMeshAgent enemy;
	GameObject Player;
	float previousAttack = 0;
	float cooldown = 2;
	public void TakeDamage (float dmg)
	{
		health -= dmg;
		if (health <= 0f)
		{
			Despawn();
		}
	}

	private void Start()
	{
		enemy = EnemyAI.enemy;
		Player = GameObject.Find("Player");
		PlayerHP = Player.GetComponent<PlayerHealth>();
	}

	private void Update()
	{
		if (enemy.isStopped == true)
		{
			if (Time.time - previousAttack >= cooldown)
			{
				previousAttack = Time.time;
				PlayerHP.DecreaseHealth(damage);
			}
		}
	}

	void Despawn()
	{
		Destroy(gameObject);
	}
	
}
// haha damn