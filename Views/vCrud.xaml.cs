using Newtonsoft.Json;
using rtoasaS6b.Models;
using System.Collections.ObjectModel;

namespace rtoasaS6b.Views;

public partial class vCrud : ContentPage
{

	private const string Url = "http://127.0.0.1/moviles/wsestudiantes.php";
	private readonly HttpClient cliente = new HttpClient();

	private ObservableCollection<Estudiante> _estudiante;

	public vCrud()
	{
		InitializeComponent();
		Mostrar();

    }

	public async void Mostrar()
	{
		var content = await cliente.GetStringAsync(Url);
		List<Estudiante> lista = JsonConvert.DeserializeObject<List<Estudiante>>(content);
		_estudiante = new ObservableCollection<Estudiante>(lista);
		lvEstudiante.ItemsSource = _estudiante;

	}
}