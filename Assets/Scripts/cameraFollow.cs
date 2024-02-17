﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;

    public float dampTime = 0.15f;
    private Vector3 velocity = Vector3.zero;
    private float cameraZ = 0;

    private Camera camera;

    void Start () {
        cameraZ = transform.position.z;
        camera = GetComponent<Camera>();
    }
	
    void FixedUpdate () {
        if (player) {
            Vector3 delta = player.transform.position - camera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, cameraZ));
            Vector3 destination = transform.position + delta;
            destination.z = cameraZ;
            transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, dampTime);
        }
    }
}
