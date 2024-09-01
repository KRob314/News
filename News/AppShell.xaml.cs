namespace News
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("articleview", typeof(Views.ArticleView));
            Routing.RegisterRoute("settingsview", typeof(Views.SettingsView));
        }
    }
}
