using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Alpha.Phases.Rounding.Roundup
{
    public class Stage2IncrementNewsPapers : MonoBehaviour
    {
        public Stage2DoorStepManager stepMan;
        public Stage2WagesManager wageMan;
        public bool runOnce;
        public GameObject strikeImage;
        public BoxCollider doorStepTrigger;
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Newspaper"))
            {
                if (!runOnce)
                {
                    wageMan.wagesValue +=56;
                    stepMan.AddDoorstep();
                    strikeImage.gameObject.SetActive(true);
                    doorStepTrigger.enabled = false;
                    runOnce = true;
                }
               
            }
        }

    }
}
