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

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        private void verbindungSuchenbtn_Click(object sender, EventArgs e)
        {

           

        }

        private void stationSuchenbtn_Click(object sender, EventArgs e)
        {
           
            
            
        }

        private void abfahrtsplanbtn_Click(object sender, EventArgs e)
        {
            Abfahrtsplan ab = new Abfahrtsplan();
            ab.Show();
            



        }

        

        private void sucheVerbindungbtn_Click(object sender, EventArgs e)
        
        {
            List<Connection> List = itransport.GetConnections(vonInputcmbx.Text,nachInputcmbx.Text).ConnectionList;
          
            
               foreach (Connection Connection in List)
                {
               
                    Verbindungendatagrid.Rows.Add(Connection.From.Station.Name, Connection.To.Station.Name, Connection.From.Departure, Connection.To.Arrival,Connection.To.Platform);
                
                }        

        }

       

        private void vonInputcmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            List<Station> Station = itransport.GetStations("").StationList;

            foreach (Station st in Station)
            {
                vonInputcmbx.Items.Add(st.Name);
            }
            

            
            vonInputcmbx.AutoCompleteMode = AutoCompleteMode.Suggest;
            vonInputcmbx.AutoCompleteSource = AutoCompleteSource.ListItems;
            */
        }

        private void nachInputcmbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}