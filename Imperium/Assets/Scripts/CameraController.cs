using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class CameraController : MonoBehaviour
{
    public Transform playerPos ;

    void FixedUpdate()
    {
        if (playerPos.position.x == transform.position.x && playerPos.position.y == transform.position.y) return;
        transform.position = new Vector3(playerPos.position.x, playerPos.position.y, transform.position.z);
    }
}
