using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwissTransport.Core;
using SwissTransport.Models;

namespace SwissTransportGUI
{
    internal class Verbindungen
    {
        ITransport itransport = new Transport();
        Transport transport = new Transport();


        public int MyProperty { get; set; }

        public List<Station> StartStation
        {
            get { return transport.GetStations("Luzern").StationList; }
        }
      

    }
}
