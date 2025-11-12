//using static Android.Webkit.WebStorage;
using System.Collections.Generic;
using System.Collections.ObjectModel;
//using static Android.Webkit.WebStorage;
namespace DataBinding.Coleccion.NewFolder1;

public partial class MainPage : ContentPage
{

    public ObservableCollection<OrigenDePaquete> Origenes { get; }

    public MainPage()
    {
        
        InitializeComponent();
        OrigenDePaquete? origenSeleccionado = null;                                                                                                               
       Origenes = new ObservableCollection<OrigenDePaquete>();
        //_origenes = new List<OrigenDePaquete>();
        CargarDatos();
        OrigenesListView.ItemsSource = Origenes;

        if (Origenes.Count > 0)
        {
            origenSeleccionado = Origenes[0];
        }
        BindingContext = this;
        //OrigenesListView.ItemsSource = Origenes;
        //OrigenesListView.SelectedItem = origenSeleccionado;
    }

    private void CargarDatos()
    {
        Origenes.Add(new OrigenDePaquete
        {
            Nombre = "nuget.org",
            Origen = "https://api.nuget.org/v3/index.json",
            EstaHabilitado = true,
        });

        Origenes.Add(new OrigenDePaquete
        {
            Nombre = "Microsoft visual Studio offiline Packages",
            Origen = @"c:\\Program Files(x86)\\Microsoft SDKs\\NuGetPackages",
            EstaHabilitado = false,
        });
    }

    private void OnAgregarButtonClicked(object sender, EventArgs e)
    {
        var origen = new OrigenDePaquete
        {
            Nombre = "Origen del paquete",
            Origen = "URL o ruta del origen del paquete",
            EstaHabilitado = false,
        };

        Origenes.Add(origen);
        //OrigenesListView.ItemsSource = null;
        //OrigenesListView.ItemsSource = Origenes;
        //OrigenesListView.SelectedItem = origen;
    }

    private void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        //OrigenDePaquete seleccionado =
          //  (OrigenDePaquete)OrigenesListView.SelectedItem;
          OrigenDePaquete seleccionado = null;

        if (seleccionado != null)
        {
            var indice = Origenes.IndexOf(seleccionado);
            OrigenDePaquete? nuevoSeleccionado;         //el signo ? = asepta null
            if (Origenes.Count > 1)
            {
                //hay mas de un elemento
                
                if (indice < Origenes.Count - 1)
                {
                    //El elemento seleccionado no es el ultimo
                    nuevoSeleccionado = Origenes[indice + 1];
                }
                else
                {
                    //El elemento seleccionado es el ultimo 
                    nuevoSeleccionado = Origenes[indice - 1];
                }
            }
            else
            {
                //Solo hay un elemento
                nuevoSeleccionado = null;
            }

            Origenes.Remove(seleccionado);
            //OrigenesListView.ItemsSource = null;
            //OrigenesListView.ItemsSource = _origenes;
            //OrigenesListView.SelectedItem = nuevoSeleccionado;

            //ActualizarCamposDeEntrada();
        }
    }

    private void OrigenesListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        //OrigenDePaquete origenSeleccionado =
         //   (OrigenDePaquete)OrigenesListView.SelectedItem;
        //if (origenSeleccionado != null)
        //{
         //   NombreEntry.Text = origenSeleccionado.Nombre;
         //   OrigenEntry.Text = origenSeleccionado.Origen;
       // }
        //else
       // {
         //   NombreEntry.Text = string.Empty;
         //   OrigenEntry.Text = string.Empty;
        //}
    }

    private void OnActualizar(object sender, EventArgs e)
    {
        //OrigenDePaquete origenSeleccionado =
         //   OrigenesListView.SelectedItem as OrigenDePaquete;
       // if (origenSeleccionado != null)
       // {
       //     origenSeleccionado.Nombre = NombreEntry.Text;
       //     origenSeleccionado.Origen = OrigenEntry.Text;
        //    OrigenesListView.ItemsSource = null;
         //   OrigenesListView.ItemsSource = _origenes;
         //   OrigenesListView.SelectedItem = origenSeleccionado;
        //}
    }
}