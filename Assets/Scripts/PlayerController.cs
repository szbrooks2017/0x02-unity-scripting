using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 1000f;
    private int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, speed * Time.deltaTime);

        if ( Input.GetKey("d"))
        {
            rb.AddForce(speed * Time.deltaTime, 0, 0);
        }
        if ( Input.GetKey("a"))
        {
            rb.AddForce(-speed * Time.deltaTime, 0, 0);
        }
        if ( Input.GetKey("w"))
        {
            rb.AddForce(0, speed * Time.deltaTime, 0);
        }
        if ( Input.GetKey("s"))
        {
            rb.AddForce(0, -speed * Time.deltaTime, 0);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Collider>().tag == "Pickup");
        {
            score++;
            Debug.Log($"Score: {score}");
        }
    }
}