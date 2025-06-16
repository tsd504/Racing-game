using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class InputController : MonoBehaviour
{
    public float ThrottleInput { get; private set; }
    public float SteerInput { get; private set; }
    public float BrakeInput { get; private set; }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        SteerInput = Input.GetAxis("Horizontal");
        ThrottleInput = Input.GetAxis("Fire2");
        BrakeInput = Input.GetAxis("Fire1");
    }
}