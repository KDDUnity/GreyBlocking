using UnityEngine;

public class SpawnPointShiny : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject objectToSpawn;
    public Transform spawnPoint;

   public void SpawnObject()
    {
        Instantiate(
            objectToSpawn,
            spawnPoint.position,
            spawnPoint.rotation
            );
    }
}
