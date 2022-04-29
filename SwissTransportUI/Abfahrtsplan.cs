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


            try
            {
               
                
                foreach (StationBoard sb in List.Entries)
                {
                    abfahrtsPlanDatagrid.Rows.Add(List.Station.Name, sb.To, string.Format("{0:HH:mm}", sb.Stop.Departure));
                }
                

               
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Fehlermeldung", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
       

        }

        private void ortInputButton_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void ortInputButton_KeyUp(object sender, KeyEventArgs e)
        {
            if(ortInputButton.Text.Length == 1)
            {
                ortInputButton.Items.Clear();

                string NachInput = ortInputButton.Text;

                var Stationen = transport.GetStations(NachInput);

                List<string> liste = new List<string>();

                foreach (var Station in Stationen.StationList)
                {
                    liste.Add(Station.Name);

                }
                foreach (var i in liste)
                {
                    ortInputButton.Items.Add(i);
                }

                ortInputButton.DroppedDown = true;
            }
        }
    }
}
