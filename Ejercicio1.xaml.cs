namespace Ejercicio1925597;

public partial class Ejercicio1 : ContentPage
{
    /// <summary>
    /// Inicializa la página
    /// </summary>
	public Ejercicio1()
	{
		InitializeComponent();
	}

    /// <summary>
    /// Obtiene los datos ingresados en el entry para cambiarlos de posición
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Button_Clicked(object sender, EventArgs e)
    {
        if (e1.Text != null && e2.Text != null && e3.Text != null && e4.Text != null)
        {
            try
            {
                int a = Convert.ToInt32(e1.Text);
                int b = Convert.ToInt32(e2.Text);
                int c = Convert.ToInt32(e3.Text);
                int d = Convert.ToInt32(e4.Text);
                e1.Text = d.ToString();
                e2.Text = c.ToString();
                e3.Text = b.ToString();
                e4.Text = a.ToString();
            }
            catch 
            {
                DisplayAlert("Error", "Los campos deben ser enteros", "Ok");
            }
        }
        else
        {
            DisplayAlert("Error", "Introduzca todos los campos", "Ok");
        }
    }

    /// <summary>
    /// Dirige a la siguiente página
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Button_Clicked_1(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Ejercicio2());
    }
}