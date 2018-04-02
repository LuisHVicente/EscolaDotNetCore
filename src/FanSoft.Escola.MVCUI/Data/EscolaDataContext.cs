using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace FanSoft.Escola.MVCUI.Data
{
    public class EscolaDataContext:DbContext
    {
        private readonly IConfiguration _config;
        public EscolaDataContext(IConfiguration config)
        {
            _config = config;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_config.GetConnectionString("EscolaConn"));
        }

        public DbSet<Models.Escola> Escolas { get; set; }
    }
}
