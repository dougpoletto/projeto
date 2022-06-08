using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Sistema
{
    public class PessoaContextoFactory : IDesignTimeDbContextFactory<PessoaContexto>
    {
        public PessoaContexto CreateDbContext(string[] args)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .AddUserSecrets<Main>()
                .Build();
            var connectionString = config.GetConnectionString("Default");
            return new PessoaContexto(connectionString);
        }
    }
}
