using UnityEngine;

public class BallController : MonoBehaviour
{
    private float speed=6f;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        switchDirection();
    }
    private void switchDirection()
    {
        if(Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            if(rb.velocity.z > 0)
            {
                rb.velocity = new Vector3(speed,0,0);
            }
            else
            {
                rb.velocity = new Vector3(0,0,speed);
            }
        }
    }
}