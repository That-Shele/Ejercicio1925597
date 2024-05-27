namespace Ejercicio1925597;

public partial class Ejercicio5 : ContentPage
{
    /// <summary>
    /// Inicializa la página
    /// </summary>
	public Ejercicio5()
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
    /// Obtiene los datos ingresados para calcular área y perimetro del rectángulo
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Button_Clicked_1(object sender, EventArgs e)
    {
        
        if (e1.Text != null && e2.Text != null)
        {
            try
            {
                double a = Convert.ToDouble(e1.Text);
                double b = Convert.ToDouble(e2.Text);
                double c = (a*2) + (b*2);
                e3.Text = (a * b).ToString();
                e4.Text = c.ToString();
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

}