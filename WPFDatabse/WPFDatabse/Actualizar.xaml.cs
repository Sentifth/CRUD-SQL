using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WPFDatabse.Clases;
using SQLite;

namespace WPFDatabse
{
    /// <summary>
    /// Lógica de interacción para Actualizar.xaml
    /// </summary>
    public partial class Actualizar : Window
    {
        public Actualizar()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, RoutedEventArgs e)
        {
            using (SQLite.SQLiteConnection conexion = new SQLite.SQLiteConnection(App.databasePath))
            {
                string sentenciaSQL = "update contactos set Nombre='"
                   + txtNombre.Text + "',Correo='" + txtCorreo.Text + "',Telefono=" + txtTelefono.Text;
                conexion.Execute(sentenciaSQL);
            }
            Close();
        }
    }
}
