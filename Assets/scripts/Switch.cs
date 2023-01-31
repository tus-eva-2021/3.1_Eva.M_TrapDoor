using Mono.Cecil.Cil;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public bool switchCount;
    public bool switchOff;
    public HingeJoint2D theHinge;
    // Start is called before the first frame update
    void Start()
    {
        switchOff = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(switchCount == true)
        {
            var motor = theHinge.motor;
            motor.motorSpeed = 20;
            theHinge.motor = motor;
        }
        if (switchOff == true)
        {
            var motor = theHinge.motor;
            motor.motorSpeed = -20;
            theHinge.motor = motor;
        }
    }
  
   
}
