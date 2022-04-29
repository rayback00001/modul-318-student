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
            this.Hide();
            
            
        }

      

        private void abfahrtsplanButton_Click(object sender, EventArgs e)
        {
            Abfahrtsplan ap = new Abfahrtsplan();
            ap.Show();
        }

        private void karteButton_Click(object sender, EventArgs e)
        {
            karteForms kf = new karteForms();
            kf.Show();
        }s
    }
}