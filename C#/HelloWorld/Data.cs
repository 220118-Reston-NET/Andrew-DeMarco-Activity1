using System.Collections;

namespace DataFunction
{
    public class Data
    {
        private int _numOfSkydives;
        private int _totalScubaDiveTime;
        private List<string> _amusementRidesList = new List<string>();

        public int Skydives
        {
            get { return _numOfSkydives; }
            set { _numOfSkydives = value; }
        }

        public int ScubaDiveTime
        {
            get { return _totalScubaDiveTime; }
            set { _totalScubaDiveTime = value; }
        }

        //retun the number of skydives
        public int totalSkydives()
        {
            _numOfSkydives = _numOfSkydives + 1;
            return _numOfSkydives;
        }

        public int totalScubaDiveTime(int time)
        {
            _totalScubaDiveTime = _totalScubaDiveTime + time;
            return _totalScubaDiveTime;
        }

        //Add amusement ride to list
        public void AddAmusementRideToList(string ride)
        {
            bool isThere = false;
            //check to see if the ride is in the list if it is then break and say the user has gone on that ride
            foreach (string item in _amusementRidesList)
            {
                if(ride == item)
                {
                    Console.WriteLine($"You already added {ride} to the list! No need for duplicates.");
                    isThere = true;
                    break;
                }
            }

            //otherwise if the ride doesn't appear, then isThere is going to be false and you should tell them they did not go on that ride
            if (isThere == false)
            {
                _amusementRidesList.Add(ride);
            }
            
        }

        public void PrintAmusementRideList()
        {
            foreach (string item in _amusementRidesList)
            {
                Console.WriteLine(item);
            }
        }

        public void RemoveRideFromList(string ride)
        {
            bool isThere = false;
            //check to see if the ride is in the list if it is then break and say the user has gone on that ride
            foreach (string item in _amusementRidesList)
            {
                if(ride == item)
                {
                    Console.WriteLine($"Okay. {ride} waas removed from the list.");
                    _amusementRidesList.Remove(ride);
                    isThere = true;
                    break;
                }
            }

            //otherwise if the ride doesn't appear, then isThere is going to be false and you should tell them they did not go on that ride
            if (isThere == false)
            {
                Console.WriteLine("This ride is currently not in your list anyways!");
            }
            
        }

        public void SearchForRide(string ride)
        {
            bool isThere = false;
            //check to see if the ride is in the list if it is then break and say the user has gone on that ride
            foreach (string item in _amusementRidesList)
            {
                if(ride == item)
                {
                    Console.WriteLine($"You have gone on {ride}");
                    isThere = true;
                    break;
                }
            }

            //otherwise if the ride doesn't appear, then isThere is going to be false and you should tell them they did not go on that ride
            if (isThere == false)
            {
                Console.WriteLine($"You have not gone on {ride}");
            }

        }

    } 
    
}