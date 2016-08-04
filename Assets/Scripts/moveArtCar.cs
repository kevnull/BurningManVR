using UnityEngine;
using System.Collections;

public class moveArtCar : MonoBehaviour {

    public float thrust;
    public Rigidbody rb;
	// Use this for initialization
	void Start () {
        thrust = 10;
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        if (gameObject.name == "Gracemaster Deeps")
        {
            transform.position += Vector3.back * Time.deltaTime;
            Debug.Log(rb.velocity.magnitude);
            if (rb.velocity.magnitude < 0.8f)
            {
                rb.AddForce(-transform.right * thrust);
            }

        } else if (gameObject.name == "Future Car")
        {
            Vector3 destination = new Vector3(3.2f, -3.68f, 1f);
            transform.position = Vector3.Lerp(transform.position, destination, 0.05f * Time.deltaTime);
        } else if (gameObject.name == "Bikers")
        {
            transform.position += new Vector3(-.005f, 0, -.005f);
        } else if (gameObject.name == "Bikers (1)")
        {
            transform.position += new Vector3(0, 0, .005f);
        }

//        Debug.Log(gameObject.name);
    }
}
