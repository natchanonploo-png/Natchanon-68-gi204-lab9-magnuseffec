using UnityEngine;
using UnityEngine.InputSystem;

public class TorqueRotate : MonoBehaviour
{
    public float angularSpeed = 5f;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (Keyboard.current.dKey.isPressed)
        {
            rb.AddTorque(new Vector3(0, 0, angularSpeed));
        }
       
    }
}
