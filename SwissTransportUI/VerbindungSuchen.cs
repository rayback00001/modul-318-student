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


        private void zurueckButton_Click(object sender, EventArgs e)
        {
            menueForms mf = new menueForms();
            mf.Show();
            this.Close();
        }

        private void sucheVerbindungButton_Click(object sender, EventArgs e)
        {

            try
            {

                var List = transport.GetConnections(vonInputcmbx.Text, nachInputcmbx.Text).ConnectionList;
               
          
                foreach (Connection connection in List)
                {
                    
                    verbindungSucheDatagrid.Rows.Add(connection.From.Station.Name, connection.To.Station.Name, string.Format("{0:HH:mm}",
                    connection.From.Departure), string.Format("{0:HH:mm}", connection.To.Arrival), connection.From.Platform);
                    
                 
                }

               
            }
            
            catch(ArgumentNullException)

            {
                MessageBox.Show("Ortsnamen vollständig und korrekt eingeben!");
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message, "Fehlermeldung", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      

        private void vonInputcmbx_KeyUp(object sender, KeyEventArgs e)
        {

                if(vonInputcmbx.Text.Length == 3)
                {
                    vonInputcmbx.Items.Clear();

                    string VonInput = vonInputcmbx.Text;

                    var Stationen = transport.GetStations(VonInput);

                    List<string> list = new List<string>();

                    foreach (var Station in Stationen.StationList)
                     {
                         list.Add(Station.Name);

                     }
                     foreach (var i in list)
                     {
                        vonInputcmbx.Items.Add(i);
                     }
                

                }

        }

        private void nachInputcmbx_KeyUp(object sender, KeyEventArgs e)
        {
            if (nachInputcmbx.Text.Length == 4)
            {
                nachInputcmbx.Items.Clear();

                string NachInput = nachInputcmbx.Text;

                var Stationen = transport.GetStations(NachInput);

                List<string> list = new List<string>();

                foreach (var Station in Stationen.StationList)
                {
                    list.Add(Station.Name);

                }
                foreach (var i in list)
                {
                    nachInputcmbx.Items.Add(i);
                }


            }
        }

        
    }
}
