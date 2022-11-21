using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M7Actividad2.Model.Repository
{
    internal interface VueloRespositoryInterface
    {
        Vuelo[] GetAll();
        Vuelo getByFlightNumber(string flightNumber);
        Vuelo[] getByOriginAirport(string originAirport);
        Vuelo[] getByDestinationAirport(string destinationAirport);
        Vuelo[] getByAirline(string airline);
        Vuelo[] getByDates(DateTime startTime, DateTime endDate);
    }
}
