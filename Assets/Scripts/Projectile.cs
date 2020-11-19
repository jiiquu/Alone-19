using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float launchForce = 10.0f;
    private Rigidbody rigidBody = null;

    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    public void Launch()
    {
        rigidBody.AddRelativeForce(Vector3.forward * launchForce, ForceMode.Impulse);
        Destroy(gameObject, 5.0f);
    }
}
