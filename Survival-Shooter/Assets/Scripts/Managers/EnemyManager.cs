using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public GameObject enemy;
    public float spawnTime = 3f;
    public Transform[] spawnPoints;


    private void Start ()
    {
        //Executing spawn point
        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }


    private void Spawn ()
    {
        //If player has died
        if (playerHealth.currentHealth <= 0f)
        {
            return;
        }
        //Get random value
        int spawnPointIndex = Random.Range (0, spawnPoints.Length);
        //Duplicating enemies
        Instantiate(enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);

    }
}
