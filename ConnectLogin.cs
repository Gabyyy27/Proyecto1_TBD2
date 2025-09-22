using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iAnywhere.Data.SQLAnywhere;

namespace Proyecto1_TBD2
{
    public partial class ConnectLogin : Form
    {
        public string ConnectionName { get; private set; }

        public ConnectLogin()
        {
            InitializeComponent();
        }

        private void btn_Conectar_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectionName = txtConnectionName.Text;

                if (string.IsNullOrEmpty(ConnectionName))
                {
                    MessageBox.Show("Por favor ingrese un nombre para la conexión.");
                    return;
                }
                var conexionesGuardadas = new ConexionesGuardadas
                {
                    Name = ConnectionName,
                    Server = txtServer.Text,
                    Database = txtDatabase.Text,
                    User = txtUser.Text,
                    Password = txtPassword.Text
                };

                ConnectionStorageService.SaveConnection(conexionesGuardadas);

                DatabaseService.AddConnection(
                    ConnectionName,
                   txtServer.Text,    // Servidor 
                    txtDatabase.Text, // Nombre BD
                    txtUser.Text,     // Usuario
                    txtPassword.Text  // Contraseña
                );
                

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        
        }
    }
}
