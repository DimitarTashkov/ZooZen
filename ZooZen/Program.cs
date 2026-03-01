using Microsoft.Extensions.DependencyInjection;
using ZooZen.Extensions;
using ZooZen.Forms;
using ZooZen.Services.Interfaces;

namespace ZooZen
{
    internal static class Program
    {
        public static ApplicationContext AppContext = null!;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();
            services.AddZooZenServices();
            var serviceProvider = services.BuildServiceProvider();

            ServiceLocator.Initialize(serviceProvider);

            var userService = ServiceLocator.GetService<IUserService>();

            AppContext = new ApplicationContext(new Login(userService));
            Application.Run(AppContext);
        }

        /// <summary>Switch the main form in the application</summary>
        public static void SwitchMainForm(Form newForm)
        {
            var old = AppContext.MainForm;
            AppContext.MainForm = newForm;
            newForm.Show();
            old?.Close();
        }
    }
}