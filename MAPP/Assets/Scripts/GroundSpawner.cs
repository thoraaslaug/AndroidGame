
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    [SerializeField] GameObject groundTileOne;
    [SerializeField] GameObject groundTileTwo;
    [SerializeField] GameObject groundTileThree;
    [SerializeField] GameObject groundTileFour;
    [SerializeField] GameObject groundTileFive;
    Vector3 nextSpawnPoint;
    private int groundNumber;
    private int groundNumberTwo;
    private int groundNumberThree;
    private int groundSpawn;

    public void SpawnTile()
    {
        GameObject[] groundTile = new GameObject[6];
        groundTile.SetValue(groundTileOne, 1);
        groundTile.SetValue(groundTileTwo, 2);
        groundTile.SetValue(groundTileThree, 3);
        groundTile.SetValue(groundTileFour, 4);
        groundTile.SetValue(groundTileFive, 5);
        System.Random rand = new System.Random();
        int rndnmb = rand.Next(1, 6);
        if (rndnmb == groundNumber || rndnmb == groundNumberTwo) {
            while (rndnmb == groundNumber || rndnmb == groundNumberTwo || rndnmb == groundNumberThree) {
                rndnmb = rand.Next(1, 6);
                
            }
        }
        if (rndnmb == 4 || rndnmb == 5)
            if ( groundNumber == 4 || groundNumberTwo == 4 || groundNumberThree == 4 || groundNumber == 5 || groundNumberTwo == 5 || groundNumberThree == 5){
                rndnmb = rand.Next(1, 4);
        }
        
        if ( rndnmb == 4 && groundSpawn != 0) {
            nextSpawnPoint.z += 10;
        }
        if (rndnmb == 5 && groundSpawn != 0) {
            nextSpawnPoint.z += 15/2;
        }
        GameObject temp = Instantiate(groundTile[rndnmb], nextSpawnPoint, Quaternion.identity); // no rotation
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;
        groundNumberThree = groundNumberTwo;
        groundNumberTwo = groundNumber;
        groundNumber = rndnmb;
        groundSpawn = 1;
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
