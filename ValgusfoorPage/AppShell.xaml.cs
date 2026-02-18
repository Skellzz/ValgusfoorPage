namespace ValgusfoorPage
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var startPage = new StartPage();

            var navPage = new NavigationPage(startPage)
            {
                BarBackgroundColor = Colors.Blue,
                BarTextColor = Colors.White
            };
            return new Window(navPage);
        }
    }
}
