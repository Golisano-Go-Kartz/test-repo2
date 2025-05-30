using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    private float turnSpeed = 96.0f;
    private float speed = 20.0f;
    private float horizontalInput;
    private float verticalInput;

    float ForwardSpeed(float speedInput)
    {
        float fspeed = Time.deltaTime * speedInput * verticalInput;
        return fspeed;
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * ForwardSpeed(speed) );
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
