using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Alpha.Phases.Rounding.Roundup
{
    public class CameraCollision : MonoBehaviour
    {
        public Transform target; // The player or object the camera follows
        public float smoothSpeed = 10f; // Smooth transition speed
        public float minDistance = 1f; // Minimum distance from the target
        public float maxDistance = 5f; // Default distance from the target
        public Vector3 offset = new Vector3(0, 2, -5); // Offset relative to the target
        public LayerMask collisionMask; // Layers to detect collisions

        private float currentDistance;

        private void Start()
        {
            currentDistance = maxDistance;
        }

        private void LateUpdate()
        {
            // Calculate the desired position based on the player's rotation and offset
            Vector3 desiredPosition = target.position + target.TransformDirection(offset.normalized * maxDistance);
            RaycastHit hit;

            // Raycast to detect obstacles
            if (Physics.Raycast(target.position, desiredPosition - target.position, out hit, maxDistance, collisionMask))
            {
                // Adjust the distance to the point of collision
                currentDistance = Mathf.Clamp(hit.distance, minDistance, maxDistance);
            }
            else
            {
                // No obstacles, use the maximum distance
                currentDistance = maxDistance;
            }

            // Update the desired position based on the adjusted distance
            desiredPosition = target.position + target.TransformDirection(offset.normalized * currentDistance);

            // Smoothly move the camera to the calculated position
            transform.position = Vector3.Lerp(transform.position, desiredPosition, Time.deltaTime * smoothSpeed);

            // Rotate the camera to always face the target
            transform.LookAt(target);
        }
    }
}
