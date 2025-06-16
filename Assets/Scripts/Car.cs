﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{

    public Transform centerOfMass;
    public float motorTorque = 1500f;
    public float maxSteer = 20f;
    public float decelerationSpeed = 30f;
    public float Steer { get; set; }

    public float Throttle { get; set; }

    public float Brake { get; set; }

    private Rigidbody _rigidbody;
    private Wheel[] wheels;


    void Start()
    {
        wheels = GetComponentsInChildren<Wheel>();
        _rigidbody = GetComponent<Rigidbody>();
        _rigidbody.centerOfMass = centerOfMass.localPosition;
    }


    void Update()
    {

        Steer = GameManager.Instance.InputController.SteerInput;
        Throttle = GameManager.Instance.InputController.ThrottleInput;
        Brake = GameManager.Instance.InputController.BrakeInput;
        foreach (var wheel in wheels)
        {
            wheel.SteerAngle = Steer * maxSteer;
            wheel.Torque = Throttle * motorTorque - Brake * motorTorque;           

        }
    }
}
