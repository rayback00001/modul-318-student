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

            this.Hide();
            VerbindungSuchen vs = new VerbindungSuchen();
            vs.ShowDialog();
            vs = null;
            this.Show();
                        
        }

        private void abfahrtsplanButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Abfahrtsplan ap = new Abfahrtsplan();
            ap.ShowDialog();
            ap = null;
            this.Show();
        }

        private void karteButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            karteForms kp = new karteForms();
            kp.ShowDialog();
            kp = null;
            this.Show();
        }

        
    }
}