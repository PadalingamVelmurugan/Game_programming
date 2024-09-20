using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawAxes : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        Vector3 direction = Vector3.right;
        Vector3 start = transform.position;
        Vector3 end = transform.position + direction * 5.0f;
        Debug.DrawLine(start, end, Color.red);

        Vector3 direction2 = Vector3.up;
        Vector3 start2 = transform.position;
        Vector3 end2 = transform.position + direction2 * 5.0f;
        Debug.DrawLine(start2, end2, Color.green);

        Vector3 direction3 = Vector3.forward;
        Vector3 start3 = transform.position;
        Vector3 end3 = transform.position + direction3 * 5.0f;
        Debug.DrawLine(start3, end3, Color.blue);


    }
}
