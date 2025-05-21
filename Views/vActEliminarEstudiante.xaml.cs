using rtoasaS6b.Models;

namespace rtoasaS6b.Views;

public partial class vActEliminarEstudiante : ContentPage
{
	public vActEliminarEstudiante(Estudiante datos)
	{
		InitializeComponent();
        txtCodigo.Text = datos.Codigo.ToString();
        txtNombre.Text = datos.Nombre;
        txtApellido.Text = datos.Apellido;
        txtEdad.Text=datos.Edad.ToString();
	}

    private void btnActualizar_Clicked(object sender, EventArgs e)
    {

    }

    private void btnEliminar_Clicked(object sender, EventArgs e)
    {

    }
}