using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport.Core;
using SwissTransport.Models;

namespace SwissTransportUI
{
    
    public partial class VerbindungSuchen : Form
    {
        ITransport transport = new Transport();
        public VerbindungSuchen()
        {
            InitializeComponent();
        }

        private void sucheVerbindungButton_Click(object sender, EventArgs e)
        {
            List<Connection> List = transport.GetConnections(vonInputcmbx.Text,nachInputcmbx.Text).ConnectionList;


            foreach (Connection Connection in List)
            {

                verbindungSucheDatagrid.Rows.Add(Connection.From.Station.Name, Connection.To.Station.Name, Connection.From.Departure, Connection.To.Arrival, Connection.To.Platform);

            }
        }
    }
}
