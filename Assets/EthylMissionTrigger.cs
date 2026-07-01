using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Alpha.Phases.Rounding.Roundup
{
    public class EthylMissionTrigger : MonoBehaviour
    {
        public bool isInRange;
        public Stage1TextManager textMan;
        public BoxCollider ethylTrigger;
        public SimpleRobotMovement playerCont;
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                playerCont.moveSpeed = 0;
                textMan.positionChanged = true;
                textMan.arrayPos = 16;
                ethylTrigger.gameObject.SetActive(false);
            }
        }

       
    }
}
