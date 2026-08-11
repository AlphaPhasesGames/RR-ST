using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Alpha.Phases.Rounding.Roundup
{
    public class CompassPointer : MonoBehaviour
    {
        [Header("References")]
        public Transform player;
        public Transform waypoint;

        [Header("Settings")]
        public float rotationSpeed = 5f;

        private void Update()
        {
            if (waypoint == null)
                return;

            Vector3 direction = waypoint.position - player.position;

            // Ignore height differences
            direction.y = 0f;

            Quaternion targetRotation = Quaternion.LookRotation(direction);

            transform.rotation = Quaternion.Lerp(
                transform.rotation,
                targetRotation,
                rotationSpeed * Time.deltaTime);
        }
    }
}
