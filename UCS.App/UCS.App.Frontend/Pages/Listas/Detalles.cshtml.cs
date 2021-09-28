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
    public class DetallesModel : PageModel
    {
        public Profesores Profesor{get;set;}

        

        private readonly IRepositorioEstudiante RepositorioEstudiante;

        public DetallesModel(IRepositorioEstudiante RepositorioEstudiante, IRepositorioProfesores RepositorioProfesores)
        {
            this.RepositorioEstudiante = RepositorioEstudiante;
            this.RepositorioProfesores = RepositorioProfesores;
        }

        private readonly IRepositorioProfesores RepositorioProfesores;

        

        public IEnumerable<Estudiante> Estudiantes{get;set;}
        public Estudiante Estudiante {get;set;}

        public IEnumerable<Profesores> Profesores_S{get;set;}
        public Profesores Profesores {get;set;}

        // public void OnGet()
        // {

        // }

        public IActionResult OnGet(int? profesorId, int? estudianteId)
        {
            if(profesorId.HasValue){
                Console.WriteLine("profesorId: "+profesorId);
                Profesor = RepositorioProfesores.GetProfesores(profesorId.Value);

                if(Profesor==null){
                    Console.WriteLine("Error: No se ha encontrado profesor con id:"+profesorId);
                    return RedirectToPage("./NotFound");

                } else{
                    return Page();
                } 
            } else if(estudianteId.HasValue){
                // estudianteId
                Console.WriteLine("estudianteId: "+estudianteId);
                Estudiante = RepositorioEstudiante.GetEstudiante(estudianteId.Value);

                if(Estudiante==null){
                    Console.WriteLine("Error: No se ha encontrado profesor con id:"+estudianteId);
                    return RedirectToPage("./NotFound");

                } else{
                    return Page();
                } 
            } else {
                return Page();
            }
            

        }
    }
}
