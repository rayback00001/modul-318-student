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

            try
            {

                var List = transport.GetConnections(vonInputcmbx.Text, nachInputcmbx.Text).ConnectionList;
               
          
                foreach (Connection connection in List)
                {
                    
                    verbindungSucheDatagrid.Rows.Add(connection.From.Station.Name, connection.To.Station.Name, string.Format("{0:HH:mm}",
                    connection.From.Departure), string.Format("{0:HH:mm}", connection.To.Arrival), connection.From.Platform);
                 
                }

               
            }
            
            catch(System.ArgumentNullException)

            {
                MessageBox.Show("Ortsnamen vollständig und korrekt eingeben!");
            }
            catch(HttpRequestException)
            {
                HttpResponseMessage response = new HttpResponseMessage();
                response.StatusCode = System.Net.HttpStatusCode.OK;

            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message, "Fehlermeldung", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      

        private void vonInputcmbx_KeyUp(object sender, KeyEventArgs e)
        {
            try {

               
              
                if (vonInputcmbx.Text.Length >= 3)
                {
                  
                    vonInputcmbx.Items.Clear();

                    string VonInput = vonInputcmbx.Text;

                    var Stationen = transport.GetStations(VonInput);

                    List<string> liste = new List<string>();

                    foreach (var Station in Stationen.StationList)
                    {
                        liste.Add(Station.Name);

                    }
                    foreach (var i in liste)
                    {
                        vonInputcmbx.Items.Add(i);
                    }

                    vonInputcmbx.SelectionStart = vonInputcmbx.Text.Length + 1;
                    vonInputcmbx.DroppedDown = true;

                }
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message, "Fehlermeldung", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }

        private void nachInputcmbx_KeyUp(object sender, KeyEventArgs e)
        {

            try
            {
                if (nachInputcmbx.Text.Length >= 3)
                {

                    nachInputcmbx.Items.Clear();

                    string NachInput = nachInputcmbx.Text;

                    var Stationen = transport.GetStations(NachInput);

                    List<string> liste = new List<string>();

                    foreach (var Station in Stationen.StationList)
                    {
                        liste.Add(Station.Name);

                    }
                    foreach (var i in liste)
                    {
                        nachInputcmbx.Items.Add(i);
                    }
                    nachInputcmbx.SelectionStart = nachInputcmbx.Text.Length + 1;
                    nachInputcmbx.DroppedDown = true;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Fehlermeldung", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void vonInputcmbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      
    }
}
