using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Alpha.Phases.Rounding.Roundup
{
    public class Stage1MiniManMoveScript : MonoBehaviour
    {
        public int houseNumber;
        public GameObject playerImage;
        public GameObject playerImageMap;

        public Transform house10;
        public Transform house20;
        public Transform house30;
        public Transform house40;
        public Transform house50;
        public Transform house60;
        public Transform house70;
        public Transform house80;
        public Transform house90;
        public Transform house100;

        public Transform house10Map;
        public Transform house20Map;
        public Transform house30Map;
        public Transform house40Map;
        public Transform house50Map;
        public Transform house60Map;
        public Transform house70Map;
        public Transform house80Map;
        public Transform house90Map;
        public Transform house100Map;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (houseNumber == 10)
            {
                playerImage.transform.position = house10.position;
                playerImageMap.transform.position = house10Map.position;
            }

            if (houseNumber == 20)
            {
                playerImage.transform.position = house20.position;
                playerImageMap.transform.position = house20Map.position;
            }

            if (houseNumber == 30)
            {
                playerImage.transform.position = house30.position;
                playerImageMap.transform.position = house30Map.position;
            }

            if (houseNumber == 40)
            {
                playerImage.transform.position = house40.position;
                playerImageMap.transform.position = house40Map.position;
            }

            if (houseNumber == 50)
            {
                playerImage.transform.position = house50.position;
                playerImageMap.transform.position = house50Map.position;
            }

            if (houseNumber == 60)
            {
                playerImage.transform.position = house60.position;
                playerImageMap.transform.position = house60Map.position;
            }

            if (houseNumber == 70)
            {
                playerImageMap.transform.position = house70Map.position;
                playerImage.transform.position = house70.position;
            }

            if (houseNumber == 80)
            {
                playerImage.transform.position = house80.position;
                playerImageMap.transform.position = house80Map.position;
            }

            if (houseNumber == 90)
            {
                playerImage.transform.position = house90.position;
                playerImageMap.transform.position = house90Map.position;
            }

            if (houseNumber == 100)
            {
                playerImage.transform.position = house100.position;
                playerImageMap.transform.position = house100Map.position;
            }
        }
    }
}
