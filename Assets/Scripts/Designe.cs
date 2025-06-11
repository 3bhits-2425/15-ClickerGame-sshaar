using UnityEngine;

public class Designe : MonoBehaviour
{
    public GameObject capsule;
    public float jumpHeight = 2f;
    private Rigidbody rb;
    private bool isGrounded = true;
    private int score = 0;

    void Start()
    {
        rb = capsule.GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (score == 20)
        {
            jumpHeight += 0.05f; 
        }
        if (score == 30)
        {
            jumpHeight += 0.10f;
        }
        if (score == 40)
        {
            jumpHeight += 0.15f;
        }
        if (score == 50)
        {
            jumpHeight += 0.20f;
        }

    }

    public void Jump()
    {
        if (!isGrounded) return;

        rb.velocity = new Vector3(rb.velocity.x, 0f, rb.velocity.z);
        rb.AddForce(Vector3.up * jumpHeight, ForceMode.Impulse);
        score++;
    }
}
