using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Vector3 offset;
    public Transform target;

    void Update()
    {
        Vector3 pos = target.transform.position;
        transform.position = new Vector3(transform.position.x,transform.position.y,pos.z) + offset;
    }
}
