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
using ToolTip.Assets;

namespace ToolTip
{
    /// <summary>
    /// Lógica interna para Janela2.xaml
    /// </summary>
    public partial class Janela2 : Window
    {
        string usuario = "ifc";
       
        public Janela2()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (TxtBoxUsuario.Text == usuario & PassBoxSenha.Password == "1234")
                {

                    MessageBox.Show("Logado com sucesso!");
                    Janela3 tres = new Janela3();
                    tres.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Dados Incorretos!");

                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Erro!");
            }
        }
    }
}
