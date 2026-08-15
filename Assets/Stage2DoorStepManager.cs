using UnityEngine;

namespace Alpha.Phases.Rounding.Roundup
{
    public class Stage2DoorStepManager : MonoBehaviour
    {
        public int amountOfDoorsteps;
        public Stage2TextManager textMan;

        public void AddDoorstep()
        {
            amountOfDoorsteps++;

            if (amountOfDoorsteps == 5)
            {
                textMan.positionChanged = true;
                textMan.arrayPos = 8;
            }

            if (amountOfDoorsteps == 10)
            {
                textMan.positionChanged = true;
                textMan.arrayPos = 16;
            }
        }
    }
}