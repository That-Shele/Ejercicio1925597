namespace Ejercicio1925597
{
    public partial class App : Application
    {
        /// <summary>
        /// Inicializa la aplicación, definiendo la página principal de una página de navegacion
        /// </summary>
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Ejercicio1());
        }
    }
}
