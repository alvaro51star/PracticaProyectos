using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limites : MonoBehaviour
{

    private Transform transform;
    public float limiteIzq, limiteDer;

    private void LateUpdate()
    {
        
    }

    private void FixedUpdate()
    {
        Mathf.Clamp(transform.position.x, limiteDer, limiteIzq);
    }

    // Start is called before the first frame update
    void Start()
    {
        transform = GetComponent<Transform>();
    }
}
