using SwissTransport.Core;
using SwissTransport.Models;

namespace SwissTransportUI
{
    public partial class menueForms : Form
    {

        ITransport itransport = new Transport();
        public menueForms()
        {
            InitializeComponent();
        }

        private void verbindungSuchenButton_Click(object sender, EventArgs e)
        {
           
            VerbindungSuchen vs = new VerbindungSuchen();
            vs.Show();
            
            
        }

        private void stationSuchenButton_Click(object sender, EventArgs e)
        {

        }

        private void abfahrtsplanButton_Click(object sender, EventArgs e)
        {
            Abfahrtsplan ap = new Abfahrtsplan();
            ap.Show();
        }
    }
}