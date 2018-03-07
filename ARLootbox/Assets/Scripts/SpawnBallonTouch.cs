using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.iOS;


public class SpawnBallonTouch : MonoBehaviour
{

    public GameObject spherePrefab;
    public float force = 5.0f;

    private Rigidbody rb;


    // Update is called once per frame
    void Update()
    {

        var touch = Input.GetTouch(0);
        if (touch.phase == TouchPhase.Began)
        {
            GameObject go = Instantiate(spherePrefab, transform.position, transform.rotation);
            go.GetComponent<Rigidbody>().velocity = transform.forward * force;
        }
    }
}