using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Alpha.Phases.Rounding.Roundup
{

    public class Stage2MiniManMoveScript : MonoBehaviour
    {
        public int houseNumber;
        public GameObject playerImage;
        public GameObject playerImageMap;
        public GameObject playerImage2;
        public GameObject playerImageMap2;

        public Transform house100;
        public Transform house200;
        public Transform house300;
        public Transform house400;
        public Transform house500;
        public Transform house600;
        public Transform house700;
        public Transform house800;
        public Transform house900;
        public Transform house1000;

        public Transform house100Map;
        public Transform house200Map;
        public Transform house300Map;
        public Transform house400Map;
        public Transform house500Map;
        public Transform house600Map;
        public Transform house700Map;
        public Transform house800Map;
        public Transform house900Map;
        public Transform house1000Map;

        // section 2 - 1000's

        public Transform house10002;
        public Transform house2000;
        public Transform house3000;
        public Transform house4000;
        public Transform house5000;
        public Transform house6000;
        public Transform house7000;
        public Transform house8000;
        public Transform house9000;
        public Transform house10000;

        public Transform house10002Map;
        public Transform house2000Map;
        public Transform house3000Map;
        public Transform house4000Map;
        public Transform house5000Map;
        public Transform house6000Map;
        public Transform house7000Map;
        public Transform house8000Map;
        public Transform house9000Map;
        public Transform house10000Map;

        // Update is called once per frame
        void Update()
        {
            if (houseNumber == 100)
            {
                playerImage.transform.position = house100.position;
                playerImageMap.transform.position = house100Map.position;
            }

            if (houseNumber == 200)
            {
                playerImage.transform.position = house200.position;
                playerImageMap.transform.position = house200Map.position;
            }

            if (houseNumber == 300)
            {
                playerImage.transform.position = house300.position;
                playerImageMap.transform.position = house300Map.position;
            }

            if (houseNumber == 400)
            {
                playerImage.transform.position = house400.position;
                playerImageMap.transform.position = house400Map.position;
            }

            if (houseNumber == 500)
            {
                playerImage.transform.position = house500.position;
                playerImageMap.transform.position = house500Map.position;
            }

            if (houseNumber == 600)
            {
                playerImage.transform.position = house600.position;
                playerImageMap.transform.position = house600Map.position;
            }

            if (houseNumber == 700)
            {
                playerImageMap.transform.position = house700Map.position;
                playerImage.transform.position = house700.position;
            }

            if (houseNumber == 800)
            {
                playerImage.transform.position = house800.position;
                playerImageMap.transform.position = house800Map.position;
            }

            if (houseNumber == 900)
            {
                playerImage.transform.position = house900.position;
                playerImageMap.transform.position = house900Map.position;
            }

            if (houseNumber == 1000)
            {
                playerImage.transform.position = house1000.position;
                playerImageMap.transform.position = house1000Map.position;
                playerImage2.transform.position = house10002.position;
                playerImageMap2.transform.position = house10002Map.position;
            }


            if (houseNumber == 2000)
            {
                playerImage2.transform.position = house200.position;
                playerImageMap2.transform.position = house200Map.position;
            }

            if (houseNumber == 3000)
            {
                playerImage2.transform.position = house300.position;
                playerImageMap2.transform.position = house300Map.position;
            }

            if (houseNumber == 4000)
            {
                playerImage2.transform.position = house400.position;
                playerImageMap2.transform.position = house400Map.position;
            }

            if (houseNumber == 5000)
            {
                playerImage2.transform.position = house500.position;
                playerImageMap2.transform.position = house500Map.position;
            }

            if (houseNumber == 6000)
            {
                playerImage2.transform.position = house600.position;
                playerImageMap2.transform.position = house600Map.position;
            }

            if (houseNumber == 7000)
            {
                playerImageMap2.transform.position = house700Map.position;
                playerImage2.transform.position = house700.position;
            }

            if (houseNumber == 8000)
            {
                playerImage2.transform.position = house800.position;
                playerImageMap2.transform.position = house800Map.position;
            }

            if (houseNumber == 9000)
            {
                playerImage2.transform.position = house900.position;
                playerImageMap2.transform.position = house900Map.position;
            }

            if (houseNumber == 10000)
            {
                playerImage2.transform.position = house1000.position;
                playerImageMap2.transform.position = house1000Map.position;
            }

        }
    }
}