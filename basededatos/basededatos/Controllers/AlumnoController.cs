using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using basededatos.Data;
using basededatos.Models;
using basededatos.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace basededatos.Controllers
{
    public class AlumnoController : Controller
    {
        private Conexionbd db = new Conexionbd();
        public SqlConnection conectarbd = new SqlConnection();
        public AlumnoController(Conexionbd _db)
        {
            db = _db;
        }
        public ActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Registrar(AlumnoViewModel en)
        {

            var alumnito = new alumno
            {
                Id = en.Id,
                Nombre = en.Nombre,
                Apellido = en.Apellido,
                Email = en.Email,
                Nota = en.Nota
            };

            

            db.Alumnos.Add(alumnito);
            await db.SaveChangesAsync();

            return Redirect("/Home/Index");
        }

       
    } 
}