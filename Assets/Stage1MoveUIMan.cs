using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Alpha.Phases.Rounding.Roundup
{
    public class Stage1MoveUIMan : MonoBehaviour
    {
        public Stage1MiniManMoveScript manMove;
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
