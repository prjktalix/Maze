using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehavior : MonoBehaviour
{

    private Vector3 camOffset;
    [SerializeField] private Transform target;
    [SerializeField] private float smoothTime;
    private Vector3 currentVelocity = Vector3.zero;

    // Start is called before the first frame update
    void Awake()
    {
        camOffset = transform.position - target.position;    
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosition = target.position + camOffset;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref currentVelocity, smoothTime);
    }
}
