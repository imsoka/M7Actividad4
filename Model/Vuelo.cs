using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M7Actividad4.Model
{
    internal class Vuelo
    {
        public string _flightNumber;
        public string _originAirportId;
        public DateTime _flightDate;
        public string _destinationAirportId;
        public string _airlineId;

        public Vuelo(
            string flightNumber, string originAirportId, string destinationAirportId, 
            DateTime flightDate, string airlineId)
        {
            this._flightNumber = flightNumber;
            this._originAirportId = originAirportId;
            this._destinationAirportId = destinationAirportId;
            this._flightDate = flightDate;
            this._airlineId = airlineId;
        }
    }
}
