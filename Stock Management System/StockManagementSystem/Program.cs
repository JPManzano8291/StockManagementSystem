namespace StockManagementSystem
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            
            //This will call the login form to show
            loginForm lf = new loginForm();
            lf.Show();
            
            Application.Run();
        }
    }
}