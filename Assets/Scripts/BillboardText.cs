using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BillboardText : MonoBehaviour
{
    [SerializeField] GameObject camera;

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(camera.transform);
        
    }
}
