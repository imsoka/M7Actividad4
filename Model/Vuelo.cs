using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M7Actividad2.Model
{
    internal class Vuelo
    {
        public string _flightNumber;
        public string _originAirportId;
        public string _flightDate;
        public string _flightTime;
        public string _destinationAirportId;
        public string _airlineId;

        public Vuelo(
            string flightNumber, string originAirportId, string destinationAirportId, 
            string flightDate, string flightTime, string airlineId)
        {
            this._flightNumber = flightNumber;
            this._originAirportId = originAirportId;
            this._destinationAirportId = destinationAirportId;
            this._flightDate = flightDate;
            this._flightTime = flightTime;
            this._airlineId = airlineId;
        }
    }
}
