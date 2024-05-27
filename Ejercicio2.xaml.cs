namespace Ejercicio1925597;

public partial class Ejercicio2 : ContentPage
{
    /// <summary>
    /// Inicializa la p�gina
    /// </summary>
	public Ejercicio2()
	{
		InitializeComponent();
	}

    /// <summary>
    /// Regresa a la p�gina anterior
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

    /// <summary>
    /// Obtiene los datos ingresados para utilizarlos en una expresi�n
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Button_Clicked_1(object sender, EventArgs e)
    {
        if (e1.Text != null && e2.Text != null ) 
        {
            try
            {
                double a = Convert.ToDouble(e1.Text);
                double b = Convert.ToDouble(e2.Text);
                double c = a + b;

                double resultado = Math.Pow(c, 2) / 2;
                e3.Text = resultado.ToString();
            }
            catch
            {
                DisplayAlert("Error", "Los campos deben ser numericos", "Ok");
            }
        }
        else
        {
            DisplayAlert("Error", "Introduzca todos los campos", "Ok");
        }
    }

    /// <summary>
    /// Dirige a la siguiente p�gina
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Button_Clicked_2(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Ejercicio3());
    }
}