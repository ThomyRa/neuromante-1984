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
        private readonly IRepositorioDirectivo RepositorioDirectivo;
        private readonly IRepositorioPersonalAseo RepositorioPersonalAseo;
        
        public IEnumerable<Estudiante> Estudiantes{get;set;}
        public Estudiante Estudiante {get;set;}

        public IEnumerable<Profesores> Profesores_S{get;set;}
        public Profesores Profesores {get;set;}

        public IEnumerable<Directivo> Directivos{get;set;}
        public Directivo Directivo {get;set;}

        public IEnumerable<PersonalAseo> PersonaldeAseo{get;set;}
        public PersonalAseo PersonalAseo {get;set;}

        public PersonasModel(IRepositorioEstudiante RepositorioEstudiante, IRepositorioProfesores RepositorioProfesores, IRepositorioDirectivo RepositorioDirectivo, IRepositorioPersonalAseo RepositorioPersonalAseo)
        {
            this.RepositorioEstudiante = RepositorioEstudiante;
            this.RepositorioProfesores = RepositorioProfesores;
            this.RepositorioDirectivo = RepositorioDirectivo;
            this.RepositorioPersonalAseo = RepositorioPersonalAseo;
        }

        public void OnGet()
        {
            Estudiantes = RepositorioEstudiante.GetAllEstudiante();
            Profesores_S = RepositorioProfesores.GetAllProfesores();
            Directivos = RepositorioDirectivo.GetAllDirectivo();
            PersonaldeAseo = RepositorioPersonalAseo.GetAllPersonalAseo();      
        }
    }
}
