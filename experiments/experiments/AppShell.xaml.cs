using experiments.Models;

namespace experiments
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("persondetails", typeof(PersonDetailsPage));

        }
    }
}
