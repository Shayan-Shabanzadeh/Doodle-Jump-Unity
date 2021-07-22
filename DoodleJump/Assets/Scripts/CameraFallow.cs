using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class CameraFallow : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = .3f;
    void LateUpdate()
    {
        if (target.position.y > transform.position.y)
        {
            Vector3 newPos = new Vector3(transform.position.x ,target.position.y , transform.position.z );
            transform.position = newPos;
        }
    }
}
