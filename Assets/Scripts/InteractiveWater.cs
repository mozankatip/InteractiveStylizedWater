using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveWater : MonoBehaviour
{
    [SerializeField] RenderTexture renderTexture;
    [SerializeField] Transform interactor;


    void Awake()
    {
        Shader.SetGlobalTexture("_GlobalEffectRT", renderTexture);
        Shader.SetGlobalFloat("_ProjectionSize", GetComponent<Camera>().orthographicSize);
    }

    private void Update()
    {
        transform.position = new Vector3(interactor.transform.position.x, transform.position.y, interactor.transform.position.z);
        Shader.SetGlobalVector("_Position", transform.position);
    }

}
