using System.Security.Cryptography;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using System;
using UnityEngine.InputSystem.Controls;
using Unity.Mathematics;

public class CameraPivot : MonoBehaviour
{
    [SerializeField] private Transform playerCamera;

    void Update()
    {
        Vector3 newDirection = Vector3.RotateTowards(transform.position, transform.position - playerCamera.position, math.INFINITY, math.INFINITY);
        transform.rotation = Quaternion.LookRotation(newDirection);
    }
}
