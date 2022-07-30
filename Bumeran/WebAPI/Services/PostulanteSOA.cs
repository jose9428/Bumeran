using WebAPI.Models;
using WebAPI.Transfers;

namespace WebAPI.Services
{
    public partial class PostulanteSOA
    {
        public static List<Postulante> ListarPostulantes ()
        {
            BDBumeranContext db = new BDBumeranContext();
            return db.Postulantes.ToList();
        }

        public static ApiResponse RegistroPostulante(PostulanteDt obj)
        {
            ApiResponse apiResponse = new ApiResponse();
            BDBumeranContext db = new BDBumeranContext();
            try
            {
                Postulante objPost = new Postulante()
                {
                  Apellido = obj.Apellido,  
                  Celular = obj.Celular,
                  Conocimientos = obj.Conocimientos,
                  Direccion = obj.Direccion,
                  Dni=obj.Dni,  
                  Expericencia = obj.Expericencia,  
                  FechaNacimiento = obj.FechaNacimiento,
                  Foracademica = obj.Foracademica,   
                  Genero=obj.Genero,
                  Idioma=obj.Idioma,
                  Nombre=obj.Nombre,
                  Salario=obj.Salario,
                  Nacionalidad=obj.Nacionalidad
                };

                db.Postulantes.Add(objPost);
                if (db.SaveChanges() == 0)
                {
                    apiResponse.msj = "No se ha podido registrar postulante";
                    apiResponse.estatus = 500;
                }
            }
            catch (Exception ex)
            {
                apiResponse.msj = ex.Message;
                apiResponse.estatus = 500;
            }

            return apiResponse;
        }

    }
}
