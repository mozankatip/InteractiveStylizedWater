using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RippleTrigger : MonoBehaviour
{
    public ParticleSystem ripple;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 4)
        {
            ripple.Play();
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.layer == 4)
        {
            ripple.Stop();
        }
    }
}
