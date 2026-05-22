using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus.Interaction;
using System.Linq;
using Oculus.Interaction.HandGrab;

public class StethoscopeController : MonoBehaviour
{
    [SerializeField]
    private GameObject stethosopceFront;
    


    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name.Contains("Hand"))
        {
            Debug.Log("Kollision mit " + collision.gameObject.name);
            stethosopceFront.SetActive(true);
            stethosopceFront.transform.position = gameObject.transform.position;
            stethosopceFront.transform.rotation = gameObject.transform.rotation;
            gameObject.SetActive(false);
        }
    }
}
