using UnityEngine;
using UnityEngine.InputSystem;

public class Angular : MonoBehaviour
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
        if (Keyboard.current.aKey.isPressed)
        {
            rb.angularVelocity = new Vector3(0, angularSpeed, 0);
        }
        else
        {
             rb.angularVelocity = Vector3.zero;
        }
    }
}
