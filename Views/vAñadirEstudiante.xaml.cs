using System.Net;

namespace rtoasaS6b.Views;

public partial class vAñadirEstudiante : ContentPage
{
	public vAñadirEstudiante()
	{
		InitializeComponent();
	}

    private void btnAñadir_Clicked(object sender, EventArgs e)
    {
		try
		{
			WebClient cliente = new WebClient();
			var parametros =new System.Collections.Specialized.NameValueCollection();
			parametros.Add("nombre", txtNombre.Text);
			parametros.Add("apellido",txtApellido.Text);
			parametros.Add("edad", txtEdad.Text);

			cliente.UploadValues
				("http://127.0.0.1/moviles/wsestudiantes.php", "POST", parametros);
			Navigation.PushAsync(new vCrud());


		}
		catch (Exception ex)
		{
			DisplayAlert("Error", ex.Message, "cerrar");
		
		}
    }
}