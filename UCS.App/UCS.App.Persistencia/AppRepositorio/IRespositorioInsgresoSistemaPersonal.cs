using System.Collections.Generic;
using UCS.App.Dominio;

namespace UCS.App.Persistencia.AppRepositorio
{
    public interface IRepositorioSistemaIngresoPersonal
    {
        
        IEnumerable<SistemaIngresoPersonal> GetAllSistemaIngresoPersonal();
        //AddSistemaIngresoPersonal
        SistemaIngresoPersonal AddSistemaIngresoPersonal(SistemaIngresoPersonal SistemaIngresoPersonal);
        //UptadateSistemaIngresoPersonal
        SistemaIngresoPersonal UpdateSistemaIngresoPersonal(SistemaIngresoPersonal SistemaIngresoPersonal);
        //DeleteSistemaIngresoPersonal
        void DeleteSistemaIngresoPersonal (int idSistemaIngresoPersonal);
        //GetSistemaIngresoPersonal
        SistemaIngresoPersonal GetSistemaIngresoPersonal(int idSistemaIngresoPersonal);
    }

}