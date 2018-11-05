﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public Transform playerTransform;
    public Joystick joystick;

    private Vector3 offset;
    private float currentX = 0.0f;
    private float currentY = 0.0f;
    private float sensitivityX = 3.0f;
    private float sensitivityY = 1.0f;

   /*  void Start ()
    {
        offset = transform.position - player.transform.position;
    }*/

    private void Update() {
        currentX += joystick.Horizontal * sensitivityX;    
        currentY += joystick.Vertical * sensitivityY;
    }

    void LateUpdate ()
    {
        Vector3 offset = new Vector3 (0, 0, -10f);
        Quaternion rotation = Quaternion.Euler (currentY, currentX, 0);
        transform.position = playerTransform.position + (rotation * offset);
        transform.LookAt(playerTransform);
    }
}