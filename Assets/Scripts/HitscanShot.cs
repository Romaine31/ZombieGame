using UnityEngine;

public class HitscanShot : MonoBehaviour
{

	public float damage = 20f;
	public float range = 100f;
	
	public Camera PlayerView;
	
	void Update(){
		
		if (Input.GetButtonDown("Fire1"))
		{
			Shoot();
		}
		
	}

	void Shoot()
	{
		RaycastHit hit;
		if (Physics.Raycast(PlayerView.transform.position, PlayerView.transform.forward, out hit, range))
		{
			EnemyOne Enemy = hit.transform.GetComponent<EnemyOne>();
			if (Enemy != null)
			{
				Enemy.TakeDamage(damage);
			}
		}
	}
}
