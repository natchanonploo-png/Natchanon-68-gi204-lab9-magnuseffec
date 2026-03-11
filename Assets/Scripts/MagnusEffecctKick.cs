using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class MagnusEffectKick : MonoBehaviour
{
    public float kickForce = 20f;
    public float spinAmount = 10f;
    public float magnusStrength = 0.5f;

    private Rigidbody rb;
    private bool isShot = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame && !isShot)
        {
            rb.AddForce(Vector3.forward * kickForce, ForceMode.Impulse);

            // ให้ลูกบอลหมุน
            rb.AddTorque(Vector3.up * spinAmount, ForceMode.Impulse);

            isShot = true;
        }
    }

    private void FixedUpdate()
    {
        if (!isShot) return;

        Vector3 velocity = rb.linearVelocity;
        Vector3 spin = rb.angularVelocity;

        Vector3 magnusForce = magnusStrength * Vector3.Cross(spin, velocity);

        rb.AddForce(magnusForce);
    }
}