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
        
        public DetallesModel(IRepositorioEstudiante RepositorioEstudiante, IRepositorioProfesores RepositorioProfesores, IRepositorioDirectivo RepositorioDirectivo, IRepositorioPersonalAseo RepositorioPersonalAseo)
        {
            this.RepositorioDirectivo = RepositorioDirectivo;
            this.RepositorioEstudiante = RepositorioEstudiante;
            this.RepositorioProfesores = RepositorioProfesores;
            this.RepositorioPersonalAseo = RepositorioPersonalAseo;
        }
        private readonly IRepositorioDirectivo RepositorioDirectivo;
        public IEnumerable<Directivo> Directivos{get;set;}
        public Directivo Directivo {get;set;}
        private readonly IRepositorioProfesores RepositorioProfesores;
        public IEnumerable<Profesores> Profesores_S{get;set;}
        public Profesores Profesor{get;set;}
        
        private readonly IRepositorioEstudiante RepositorioEstudiante;
        public IEnumerable<Estudiante> Estudiantes{get;set;}
        public Estudiante Estudiante {get;set;}

        private readonly IRepositorioPersonalAseo RepositorioPersonalAseo;
        public IEnumerable<PersonalAseo> PersonaldeAseo{get;set;}
        public PersonalAseo PersonalAseo {get;set;}

        // public void OnGet()
        // {

        // }

        public IActionResult OnGet(int? profesorId, int? estudianteId, int? directivoId, int? PersonalAseoId)
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
            } else if(directivoId.HasValue){
                Console.WriteLine("DirectivoId: "+directivoId);
                Directivo = RepositorioDirectivo.GetDirectivo(directivoId.Value);

                if(Directivo==null){
                    Console.WriteLine("Error: No se ha encontrado directivo con id:"+directivoId);
                    return RedirectToPage("./NotFound");

                } else{
                    return Page();
                } 
            }

            else if(PersonalAseoId.HasValue){
                // estudianteId
                Console.WriteLine("PersonalAseoId: "+PersonalAseoId);
                PersonalAseo = RepositorioPersonalAseo.GetPersonalAseo(PersonalAseoId.Value);

                if(PersonalAseo==null){
                    Console.WriteLine("Error: No se ha encontrado profesor con id:"+PersonalAseoId);
                    return RedirectToPage("./NotFound");

                } else{
                    return Page();
                } 
            }
            
            else {
                return Page();
            }
            

        }
    }
}
