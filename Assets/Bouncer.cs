using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncer : MonoBehaviour
{
    public float bouncePower = 755;
        void OnCollisionEnter(Collision collision)
        {
            Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
            
            PlayerController pc = collision.gameObject.GetComponent<PlayerController>();

            Vector3 bounce = Vector3.Reflect(pc.lastvelocity, collision.contacts[0].normal);

            Debug.Log("bounce " + bounce * bouncePower);
            Debug.Log("Velocity" + pc.lastvelocity);

            rb.AddForce(bounce.normalized * bouncePower);
        }
}
