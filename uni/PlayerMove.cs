using UnityEngine;


public class PlayerMove : MonoBehaviour {

	public Rigidbody rigidBody;
    public float forwardForce = 2000f;
    public float sidewayForce = 500f;

	void Start () {
        rigidBody = GetComponent<Rigidbody>();
    }
	
	void FixedUpdate () {

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rigidBody.AddForce(sidewayForce*Time.deltaTime, 0, 0);
        }

        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            rigidBody.AddForce(-sidewayForce* Time.deltaTime, 0, 0);
        }

        else if (Input.GetKey(KeyCode.UpArrow))
        {
            rigidBody.AddForce(0, 0, forwardForce * Time.deltaTime);
        }

        else if (Input.GetKey(KeyCode.DownArrow))
        {
            rigidBody.AddForce(0, 0, -forwardForce * Time.deltaTime);
        }


    }
}
