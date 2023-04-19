using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerObject : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 rotation;
    void Start()
    {
        transform.Rotate(rotation * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
