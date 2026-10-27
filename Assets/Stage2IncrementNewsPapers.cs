using UnityEngine;

namespace Alpha.Phases.Rounding.Roundup
{
    public class Stage2IncrementNewsPapers : MonoBehaviour
    {
        [Header("Managers")]
        public Stage2DoorStepManager stepMan;
        public Stage2WagesManager wageMan;
        public Stage2TextManager textMan;

        [Header("Delivery Order")]
        public bool isActiveDelivery;
        public GameObject arrowHighlighter;

        // Drag the NEXT correct doorstep into this field.
        public Stage2IncrementNewsPapers nextDelivery;

        [Header("Correct Delivery")]
        public bool runOnce;
        public GameObject strikeImage;
        public BoxCollider doorStepTrigger;
        public AudioSource correctSFX;
        public int wagesGiven;

        [Header("Wrong / Out Of Order Delivery")]
        public AudioSource wrongSFX;
        public int wrongArrayPosition;


        private void Start()
        {
            // Make sure the arrow matches the starting state.
            UpdateArrow();
        }


        private void OnTriggerEnter(Collider other)
        {
            // Ignore anything that isn't a newspaper.
            if (!other.CompareTag("Newspaper"))
            {
                return;
            }

            // Correct address and currently active.
            if (isActiveDelivery && !runOnce)
            {
                CorrectDelivery();
            }

            // Correct house, but not the current delivery.
            else if (!isActiveDelivery && !runOnce)
            {
                WrongDelivery();
            }
        }


        private void CorrectDelivery()
        {
            // Play correct sound.
            if (correctSFX != null)
            {
                correctSFX.Play();
            }

            // Add wages.
            wageMan.wagesValue += wagesGiven;

            // Add completed doorstep.
            stepMan.AddDoorstep();

            // Strike completed address off the list.
            if (strikeImage != null)
            {
                strikeImage.SetActive(true);
            }

            // This delivery is now complete.
            runOnce = true;

            // Turn this delivery off.
            SetActiveDelivery(false);

            // Activate the next delivery.
            if (nextDelivery != null)
            {
                nextDelivery.SetActiveDelivery(true);
            }

            // Stop this doorstep accepting more newspapers.
            if (doorStepTrigger != null)
            {
                doorStepTrigger.enabled = false;
            }
        }


        public void SetActiveDelivery(bool active)
        {
            isActiveDelivery = active;

            UpdateArrow();
        }


        private void UpdateArrow()
        {
            if (arrowHighlighter != null)
            {
                arrowHighlighter.SetActive(isActiveDelivery);
            }
        }


        private void WrongDelivery()
        {
            // Correct house, but delivered out of order.
            if (wrongSFX != null)
            {
                wrongSFX.Play();
            }

            if (textMan != null)
            {
                textMan.ResetBools();
                textMan.positionChanged = true;
                textMan.arrayPos = wrongArrayPosition;
            }
        }
    }
}