using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class Elevator
    {
        private int totalNumberOfFloors;
        private bool doorIsOpen;
        private int currentLevel;

        public Elevator(int totalNumberOfFloors)
        {
            this.totalNumberOfFloors = totalNumberOfFloors;
            currentLevel = 1;
        }

        public int NumberOfLevels
        {
            get
            {
                return totalNumberOfFloors;
            }
        }

        public int CurrentLevel
        {
            get
            {
                return currentLevel;
            }
        }

        public bool DoorIsOpen
        {
            get
            {
                return doorIsOpen;
            }
        }

        public void OpenDoor()
        {
            doorIsOpen = true;
        }

        public void CloseDoor()
        {
            doorIsOpen = false;
        }

        public void GoUp(int desiredFloor)
        {
            if (doorIsOpen == false)
            {
                if (desiredFloor > currentLevel && desiredFloor <= totalNumberOfFloors)
                {
                    currentLevel = desiredFloor;
                }
            }
        }
        public void GoDown(int desiredFloor)
        {
            if (doorIsOpen == false)
            {
                if (desiredFloor < currentLevel && desiredFloor > 0)
                {
                    currentLevel = desiredFloor;
                }
            }
        }


    }

}
