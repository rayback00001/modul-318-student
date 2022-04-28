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

            /*
            try
            {
                var station = transport.GetStations(vonInputcmbx.Text);

                List<string> list = new List<string>();

                foreach (var stat in station.StationList)
                {
                    list.Add(stat.Name.ToString());
                }

                foreach (var k in list)
                {
                    vonInputcmbx.Items.Add(k.ToString());
                    nachInputcmbx.Items.Add(k.ToString());
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Hallo");
            }

            */



           
            try
            {

                var List = transport.GetConnections(vonInputcmbx.Text, nachInputcmbx.Text).ConnectionList;
               
          
                foreach (Connection connection in List)
                {
                    
                    verbindungSucheDatagrid.Rows.Add(connection.From.Station.Name, connection.To.Station.Name, string.Format("{0:HH:mm}",
                    connection.From.Departure), string.Format("{0:HH:mm}", connection.To.Arrival), connection.To.Platform);
                    
                   

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

        private void zurueckButton_Click(object sender, EventArgs e)
        {
            menueForms mf = new menueForms();
            mf.Show();
            this.Close();
        }
    }
}
