using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnderwaterTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "MainCamera")
        {
            RenderSettings.fog = true;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "MainCamera")
        {
            RenderSettings.fog = false;
        }
    }
}