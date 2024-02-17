using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public int moveSpeed;
    public Camera cam;

    private Vector3 mousePos;
    private float x;
    private float y;
    private Rigidbody2D rigidBody2D;



    // Start is called before the first frame update
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Movement
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        if (Input.GetButtonDown("Fire1"))
        {
            shoot();
        }
        
    }



    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "water")
        {
            moveSpeed -= 2;
        }
        
        print("collided");
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        moveSpeed = 5;
    }

    private void shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit))
        {
            Debug.Log("hitting "+ hit.transform.name);
        }
    }

    private void FixedUpdate()
    {
        mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
        Vector3 lookPos = cam.ScreenToWorldPoint(mousePos);
        lookPos = lookPos - transform.position;
        float angle = Mathf.Atan2(lookPos.y, lookPos.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        rigidBody2D.velocity = new Vector2(x * moveSpeed, y * moveSpeed);
    }
}
