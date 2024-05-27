namespace Ejercicio1925597;

public partial class Ejercicio3 : ContentPage
{

    /// <summary>
    /// Inicializa la página
    /// </summary>
	public Ejercicio3()
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
    /// Obtiene los datos ingresados para calcular el promedio
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Button_Clicked_1(object sender, EventArgs e)
    {
       

        if (e1.Text != null && e2.Text != null && e3.Text != null && e4.Text != null && e5.Text != null)
        {
            try
            {
                double n1 = Convert.ToDouble(e1.Text);
                double n2 = Convert.ToDouble(e2.Text);
                double n3 = Convert.ToDouble(e3.Text);
                double n4 = Convert.ToDouble(e4.Text);
                double n5 = Convert.ToDouble(e5.Text);
                double res = (n1 + n2 + n3 + n4 + n5) / 5;
                eP.Text = res.ToString();
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
    /// Dirige a la siguiente página
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Button_Clicked_2(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Ejercicio4());
    }
}