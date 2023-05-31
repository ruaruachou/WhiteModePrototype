using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeFly : MonoBehaviour
{
    private float flySpeed = 0.10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.one * flySpeed);
    }
}
