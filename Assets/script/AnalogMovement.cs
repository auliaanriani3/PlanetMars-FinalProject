using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnalogMovement : MonoBehaviour
{
    public float speed;
    public VariableJoystick variableJoystick;
  //  public Rigidbody rb;

    public void Update()
    {
        Vector3 direction = Vector3.forward * variableJoystick.Vertical + Vector3.right * variableJoystick.Horizontal;
        transform.Translate(new Vector3(variableJoystick.Horizontal, 0, variableJoystick.Vertical) * speed * Time.deltaTime);
       // rb.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode.VelocityChange);
    }
}
