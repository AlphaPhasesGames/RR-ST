using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage1PlayerPush : MonoBehaviour
{
    public float pushPower = 2f;

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Rigidbody rb = hit.collider.attachedRigidbody;

        if (rb == null || rb.isKinematic)
            return;

        Vector3 pushDir = new Vector3(hit.moveDirection.x, 0, hit.moveDirection.z);

        rb.AddForce(pushDir * pushPower, ForceMode.Impulse);

    }
}