namespace Ejercicio1925597;

public partial class Ejercicio4 : ContentPage
{
    /// <summary>
    /// Inicializa la página
    /// </summary>
	public Ejercicio4()
	{
		InitializeComponent();
	}

    /// <summary>
    /// Regresa a la página anterior
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

    /// <summary>
    /// Obtiene el datos ingresado para calcular el cuadrado y el cubo
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Button_Clicked_1(object sender, EventArgs e)
    {
        if (e1.Text != null)
        {
            try
            {
                int a = Convert.ToInt32(e1.Text);
                e2.Text = Math.Pow(a, 2).ToString();
                e3.Text = Math.Pow(a, 3).ToString();
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
    private void Button_Clicked_2(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Ejercicio5());
    }
}