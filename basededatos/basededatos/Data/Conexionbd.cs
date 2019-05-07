using System;
using basededatos.Models;
using Microsoft.EntityFrameworkCore;


namespace basededatos.Data
{
   
    public class Conexionbd : DbContext
        {
        internal object alumno;
        public Conexionbd()
        {
        }
        public Conexionbd(DbContextOptions<Conexionbd> options)
                : base(options)
            { }
           
        public DbSet<alumno> Alumnos { get; set; }
    }
   
}
