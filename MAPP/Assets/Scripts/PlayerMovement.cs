using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    bool alive = true;

    [SerializeField ]float speed  = 5;
    [SerializeField] Rigidbody rb;
    float horizentalInput;
    [SerializeField] float horizontalMuliplier = 2f;

    private void FixedUpdate()
    {
        if (!alive) return;

        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
        Vector3 horizontalMove = transform.right * horizentalInput * speed * Time.fixedDeltaTime*horizontalMuliplier;
        rb.MovePosition(rb.position + forwardMove+horizontalMove);
    }

    // Update is called once per frame
    void Update()
    {
        horizentalInput = Input.GetAxis("Horizontal");

        if (transform.position.y < -5)
        {
            Die();
        }
    }

    public void Die()
    {
        alive = false;

        // Restart the game with a 2 second delay
        Invoke("Restart", 2);

    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
