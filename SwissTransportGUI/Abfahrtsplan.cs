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
    public partial class Abfahrtsplan : Form
    {
        ITransport itransport = new Transport();
        public Abfahrtsplan()
        {
            InitializeComponent();
        }

        private void abfahrtsPlanShowbtn_Click(object sender, EventArgs e)
        {
            

            var List = itransport.GetStationBoard(ortInputcmbx.Text, ortInputcmbx.Text);

            foreach(StationBoard sb in List.Entries)
            {
                abfahrtPlandatagrid.Rows.Add(List.Station.Name, List.Station.Name, sb.Stop.Departure);
            }
        }
    }
}
