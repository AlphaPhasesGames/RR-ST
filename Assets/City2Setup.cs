using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Alpha.Phases.Rounding.Roundup
{
    public class City2Setup : MonoBehaviour
    {
        public GameObject barriers;
        public GameObject city2Trigger;
        public Stage2TextManager textMan;
        public GameObject compass;
        public GameObject numberList1;
        public GameObject numberList2;
        public MapButtonOpen map;
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                textMan.positionChanged = true;
                textMan.arrayPos = 12;
                compass.gameObject.SetActive(false);
                barriers.gameObject.SetActive(true);
                city2Trigger.gameObject.SetActive(false);
                numberList1.gameObject.SetActive(false);
                numberList2.gameObject.SetActive(true);
                map.map2Open = true;
            }
        }
    }
}
