using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Alpha.Phases.Rounding.Roundup
{
    public class Stage2MoveUIMan : MonoBehaviour
    {
        public Stage2MiniManMoveScript manMove;
        public int houseValue;

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                manMove.houseNumber = houseValue;
            }
        }
    }
}
