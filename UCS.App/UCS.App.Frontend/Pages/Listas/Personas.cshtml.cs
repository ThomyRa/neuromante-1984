using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UCS.App.Dominio;
using UCS.App.Persistencia;
using UCS.App.Persistencia.AppRepositorio;


namespace UCS.App.Frontend.Pages
{
    public class PersonasModel : PageModel
    {
        private readonly IRepositorioEstudiante RepositorioEstudiante;
        private readonly IRepositorioProfesores RepositorioProfesores;
        

        public IEnumerable<Estudiante> Estudiantes{get;set;}
        public Estudiante Estudiante {get;set;}

        public IEnumerable<Profesores> Profesores_S{get;set;}
        public Profesores Profesores {get;set;}

        public PersonasModel(IRepositorioEstudiante RepositorioEstudiante, IRepositorioProfesores RepositorioProfesores)
        {
            this.RepositorioEstudiante = RepositorioEstudiante;
            this.RepositorioProfesores = RepositorioProfesores;
        }

        public void OnGet()
        {
            Estudiantes = RepositorioEstudiante.GetAllEstudiante();
            Profesores_S = RepositorioProfesores.GetAllProfesores();
                       
        }
    }
}
