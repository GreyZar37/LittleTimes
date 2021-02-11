using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    
    public Transform target;

    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    private void LateUpdate()
    {
        if (target != null)
        {
            Vector3 diseredPosition = target.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, diseredPosition, smoothSpeed);
            transform.position = smoothedPosition;


        }

    }

}
