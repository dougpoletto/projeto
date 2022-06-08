using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Sistema
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            var config = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .AddUserSecrets<Main>()
                .Build();
            var stringConexao = config.GetConnectionString("Default");
            //MessageBox.Show(stringConexao);

            using (var contexto = new PessoaContexto(config.GetConnectionString("Default")))
            {
                try
                {
                    contexto.Database.Migrate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void tabPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabPrincipal.SelectedTab == tabPageAtivos)
            {
                buttonTeste.Text = "Ativo";
            }
            else
            {
                buttonTeste.Text = "Inativo";
            }
        }
    }
}