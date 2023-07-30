using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellorContoller : MonoBehaviour
{
    private float rotationSpeed = 52.45f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, rotationSpeed*Time.deltaTime);
    }
}
