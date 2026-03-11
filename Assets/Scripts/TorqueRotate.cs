using UnityEngine;
using UnityEngine.InputSystem;

public class TorqueRotate : MonoBehaviour
{
    public float torqueAmount = 5f; 

    private Rigidbody rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (Keyboard.current.dKey.isPressed)
        {
            rb.AddTorque(new Vector3(0, 0, torqueAmount));
        }
        else
        {
            rb.angularVelocity = Vector3.zero;
        }
    }
}