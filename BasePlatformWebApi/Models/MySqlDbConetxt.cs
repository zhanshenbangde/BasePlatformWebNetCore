using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Logging;

namespace BasePlatformWebApi.Models
{
    public partial class MySqlDbConetxt : DbContext
    {
        public MySqlDbConetxt()
        {
        }

        public MySqlDbConetxt(DbContextOptions<MySqlDbConetxt> options)
            : base(options)
        {
        }


        //创建日志工厂
        private static ILoggerFactory Mlogger => new LoggerFactory()
                 .AddDebug((categoryName, logLevel) => (logLevel == LogLevel.Information) && (categoryName == DbLoggerCategory.Database.Command.Name))
                .AddConsole((categoryName, logLevel) => (logLevel == LogLevel.Information) && (categoryName == DbLoggerCategory.Database.Command.Name));

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var loggerFactory =
            optionsBuilder
                .UseLoggerFactory(Mlogger) //注入日志工厂
                .UseMySql(@"Server=localhost;User Id=root;Password=poya123#;Database=testcap");
        }


        public virtual DbSet<CapPublished> CapPublished { get; set; }
        public virtual DbSet<CapReceived> CapReceived { get; set; }
        public virtual DbSet<Efmigrationshistory> Efmigrationshistory { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseMySql("Server=localhost;User Id=root;Password=poya123#;Database=testcap");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Efmigrationshistory>(entity =>
            {
                entity.HasKey(e => e.MigrationId)
                    .HasName("PRIMARY");
            });
        }
    }
}
