using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour //mob spawner
{

	public GameObject Enemy;
	public int enemyCount;
	public float timeBetweenWaves = 5f;
	private float counter = 2f; //this can also be used as the wave counter
	private int waveLevel = 0;
	public int xPos;
	public int zPos;
	
	void Update()
	{
		if (counter <= 0f)
		{
			StartCoroutine(SpawnWave());
			counter = timeBetweenWaves;
		}
		
		counter -= Time.deltaTime;
	}
	
	IEnumerator SpawnWave()
	{
		waveLevel++;
		for (int i = 0; i<waveLevel; i++)
		{
			SpawnEnemy();
			yield return new WaitForSeconds(0.5f);
		}
	}
	
	void SpawnEnemy()
	{
		xPos = Random.Range(-20, 20);
		zPos = Random.Range(-20, 20);
		Instantiate(Enemy, new Vector3(xPos, 0.5f, zPos), Quaternion.identity);
	}
}
