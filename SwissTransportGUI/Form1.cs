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
            verbindungSuchenforms vsf = new verbindungSuchenforms();
            vsf.Show();
           

        }

        private void stationSuchenbtn_Click(object sender, EventArgs e)
        {
           
            
            
        }

        private void abfahrtsplanbtn_Click(object sender, EventArgs e)
        {
            Abfahrtsplan ab = new Abfahrtsplan();
            ab.Show();
            
        }

        

      

       

       
       

        
    }
}