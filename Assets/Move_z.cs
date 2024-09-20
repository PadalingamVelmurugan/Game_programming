using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_z : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {


        Vector3 direction = Vector3.forward;

        float dt = Time.deltaTime;
        float speed = 7.0f;

        Vector3 velocity = direction * speed * dt;
        transform.position = transform.position + velocity;

    }
}
