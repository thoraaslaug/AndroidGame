
using UnityEngine;

public class WallSpawner : MonoBehaviour
{
    [SerializeField] GameObject wallTile;
    Vector3 nextSpawnPoint;

    public void SpawnTile()
    {
        GameObject temp = Instantiate(wallTile, nextSpawnPoint, Quaternion.identity); // no rotation
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;
    }
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 15; i++)
        {
            SpawnTile();
        }
    }
}
