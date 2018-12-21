using System;

namespace SwissTransport
{
    public interface ITransport
    {
        Stations GetStations(string query);
        StationBoardRoot GetStationBoard(string station, string id);
        Connections GetConnections(string fromStation, string toStattion);
        Connections GetConnections(string fromStation, string toStattion, DateTime dtDate);
        object GetStationBoard(string v1, string v2, string v3, string v4);
    }
}