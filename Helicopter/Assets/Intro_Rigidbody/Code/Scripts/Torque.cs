using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Shonia;
public class Torque : BaseRBController
{
    #region Varaibles
    public float torqueSpeed = 2f;
    public Vector3 rotationDirection = new Vector3(0f, 1f, 0f);
    #endregion


    #region Custom Methods
    protected override void HandlePhysics()
    {
        Vector3 wantedTorque = Vector3.up * torqueSpeed;
        rb.AddTorque(wantedTorque);
    }
    #endregion
}
