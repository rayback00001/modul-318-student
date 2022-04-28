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
    public partial class Abfahrtsplan : Form
    {
        ITransport transport = new Transport();
        public Abfahrtsplan()
        {
            InitializeComponent();
        }

        private void abfahrtsPlanAnzButton_Click(object sender, EventArgs e)
        {

            var List = transport.GetStationBoard(ortInputButton.Text, ortInputButton.Text);

            

            if(ortInputButton.Text == List.Station.Name)
            {
                foreach (StationBoard sb in List.Entries)
                {
                    abfahrtsPlanDatagrid.Rows.Add(List.Station.Name, sb.Stop.Departure);
                }
            }
            else
            {
                MessageBox.Show("rICHI");
            }

        }
    }
}
