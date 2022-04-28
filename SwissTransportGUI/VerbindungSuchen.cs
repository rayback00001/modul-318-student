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

namespace SwissTransportGUI
{
    public partial class verbindungSuchenforms : Form
    {
        ITransport itransport = new Transport();
        public verbindungSuchenforms()
        {
            InitializeComponent();
        }

        private void vonInputcmbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sucheVerbindungbtn_Click(object sender, EventArgs e)
        {
            List<Connection> List = itransport.GetConnections(vonInputcmbx.Text, nachInputcmbx.Text).ConnectionList;


            foreach (Connection Connection in List)
            {

                Verbindungendatagrid.Rows.Add(Connection.From.Station.Name, Connection.To.Station.Name, Connection.From.Departure, Connection.To.Arrival, Connection.To.Platform);

            }
        }
    }
}
