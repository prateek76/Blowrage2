using UnityEngine;

public class playerMove : MonoBehaviour {

    public Rigidbody rb;

    public float forwardForce = 1000f;
    public float sideForce = 500f;

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); //add force just add force and will depend on framerate so to keep speed same accross all users using Time.deltatime
        if(Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
