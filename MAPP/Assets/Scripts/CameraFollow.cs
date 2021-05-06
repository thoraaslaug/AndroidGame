
using UnityEngine;

public class CameraFollow: MonoBehaviour
{

    [SerializeField] Transform player;
    [SerializeField] float maxYxel=6f;
    Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (player.position.y >= 2.5f)
        {
            Vector3 fastPos = new Vector3(0, maxYxel, player.position.z - 4f);
            transform.position = fastPos;
        }
        else
        {

            Vector3 targetPos = player.position + offset;
            targetPos.x = 0;
            transform.position = targetPos;
        }
       
    }
  
}
