using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class Airplane
    {

        private string planeNumber;
        private int totalFirstClassSeats;
        private int totalCoachSeats;
        private int bookedFirstClassSeats;
        private int bookedCoachSeats;



        public Airplane(string planeNumber, int totalFirstClassSeats, int totalCoachSeats)
        {
            this.planeNumber = planeNumber;
            this.totalFirstClassSeats = totalFirstClassSeats;
            this.totalCoachSeats = totalCoachSeats;

        }

        public string PlaneNumber
        {
            get
            {
                return planeNumber;
            }
        }

        public int TotalFirstClassSeats
        {
            get
            {
                return totalFirstClassSeats;
            }
        }

        public int TotalCoachSeats
        {
            get
            {
                return totalCoachSeats;
            }
        }

        public int BookedFirstClassSeats
        {
            get
            {
                return bookedFirstClassSeats;
            }
        }

        public int AvailableFirstClassSeats
        {
            get
            {
                return TotalFirstClassSeats - BookedFirstClassSeats;
            }
        }

        public int BookedCoachSeats
        {
            get
            {
                return bookedCoachSeats;
            }
        }

        public int AvailableCoachSeats
        {
            get
            {
                return TotalCoachSeats - BookedCoachSeats;
            }
        }


        public bool ReserveSeats(bool forFirstClass, int totalNumberOfSeats)
        {
            if (forFirstClass)
            {
                if (totalNumberOfSeats <= AvailableFirstClassSeats)
                {
                    bookedFirstClassSeats = BookedFirstClassSeats + totalNumberOfSeats;
                    
                    return true;
                }
                else
                {
                    return false;
                }
            }

            else
            {
                if (totalNumberOfSeats <= AvailableCoachSeats)
                {
                    bookedCoachSeats = BookedCoachSeats + totalNumberOfSeats;

                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
