using Unity.VisualScripting;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{

    public SpawnPointShiny ButtonSpawner;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ButtonSpawner.SpawnObject();
        }
    }
}
