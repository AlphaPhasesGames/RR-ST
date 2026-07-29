using UnityEngine;
using System.Collections.Generic;
namespace Alpha.Phases.Rounding.Roundup
{
    public class NewsPaperThrow : MonoBehaviour
    {
        [Header("Throw Settings")]
        [SerializeField] private GameObject newspaperPrefab;
        [SerializeField] private Transform spawnPoint;

        [SerializeField] private float throwForce = 15f;
        [SerializeField] private float upwardForce = 3f;

        [SerializeField] private int maxNewspapers = 10;

        private Queue<GameObject> spawnedNewspapers = new Queue<GameObject>();

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                ThrowNewspaper();
            }
        }

        private void ThrowNewspaper()
        {
            if (newspaperPrefab == null || spawnPoint == null)
                return;

            // Remove the oldest newspaper if we've reached the limit
            if (spawnedNewspapers.Count >= maxNewspapers)
            {
                GameObject oldest = spawnedNewspapers.Dequeue();

                if (oldest != null)
                    Destroy(oldest);
            }

            GameObject newspaper = Instantiate(
                newspaperPrefab,
                spawnPoint.position,
                spawnPoint.rotation);

            spawnedNewspapers.Enqueue(newspaper);

            Rigidbody rb = newspaper.GetComponent<Rigidbody>();

            if (rb != null)
            {
                Vector3 force =
                    transform.forward * throwForce +
                    transform.up * upwardForce;

                rb.AddForce(force, ForceMode.Impulse);
            }
        }
    }
}