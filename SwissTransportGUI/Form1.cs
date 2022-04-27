using SwissTransport.Core;
using SwissTransport.Models;

namespace SwissTransportGUI

{
    
    public partial class Form1 : Form
    {
        ITransport itransport = new Transport();
        public Form1()
        {
            InitializeComponent();
            

        }

        
        private void verbindungSuchenbtn_Click(object sender, EventArgs e)
        {
            
            
                            
        }

        private void stationSuchenbtn_Click(object sender, EventArgs e)
        {
           
        }

        private void abfahrtsplanbtn_Click(object sender, EventArgs e)
        {
            
        }

        

        private void sucheVerbindungbtn_Click(object sender, EventArgs e)
        
        {
            List<Connection> List = itransport.GetConnections("Luzern", "Willisau").ConnectionList;
          
            
           
               foreach (Connection Connection in List)
                {
                    dataGridView1.Rows.Add(Connection.From.Station.Name, Connection.To.Station.Name, Connection.From.Departure, Connection.To.Arrival);
                }

            
            



        }
    }
}