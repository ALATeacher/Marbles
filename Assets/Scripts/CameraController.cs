using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject target;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset.x = target.transform.position.x - transform.position.x;
        offset.y = target.transform.position.y - transform.position.y;
        offset.z = target.transform.position.z - transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = new Vector3();
        Vector3 currentPos = transform.position;
        Vector3 targetPos = target.transform.position;
        newPos.x = targetPos.x - offset.x;
        newPos.y = targetPos.y - offset.y;
        newPos.z = targetPos.z - offset.z;
        transform.position = newPos;
    }
}
