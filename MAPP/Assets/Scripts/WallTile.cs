using UnityEngine;

public class WallTile : MonoBehaviour
{
    WallSpawner wallSpawner;
    // Start is called before the first frame update
    void Start()
    {
        wallSpawner = GameObject.FindObjectOfType<WallSpawner>();
       
    }

    private void OnTriggerExit(Collider other)
    {
        wallSpawner.SpawnTile();
        Destroy(gameObject, 2);
    }

    
}