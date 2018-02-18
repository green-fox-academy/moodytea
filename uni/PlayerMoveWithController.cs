using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;


public class PlayerMoveWithController : MonoBehaviour
{

    public Rigidbody rigidBody2;
    public float forwardForce2 = 2000f;
    public float sidewayForce2 = 500f;
    private Vector3 Move;

    void Start()
    {
        rigidBody2 = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {

        if (CrossPlatformInputManager.GetButtonDown("Jump"))
        {
            rigidBody2.AddForce(0, 100, 0);
        }

        float h = CrossPlatformInputManager.GetAxis("Horizontal");
        float v = CrossPlatformInputManager.GetAxis("Vertical");

        Move = (v * Vector3.forward + h * Vector3.right).normalized;
        rigidBody2.AddForce(Move*10);
        
    }
}
