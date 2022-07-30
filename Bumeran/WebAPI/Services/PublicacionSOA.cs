using Microsoft.EntityFrameworkCore;
using WebAPI.Models;
using WebAPI.Transfers;

namespace WebAPI.Services
{
    public partial class PublicacionSOA
    {
        public static ApiResponse RegistroPublicacion(PublicacionDt obj)
        {
            ApiResponse apiResponse = new ApiResponse();
            BDBumeranContext db = new BDBumeranContext();
            try
            {
                Publicacion objPub = new Publicacion()
                {
                    Area = obj.area,
                    Descrip = obj.descrip,
                    Habilidades = obj.habilidades,
                    Jerarquia = obj.jerarquia,
                    Lugar = obj.lugar,
                    IdDepartamento = obj.idDepartamento, 
                    Departamento = obj.departamento,
                    Distrito = obj.distrito,    
                    Modalidad = obj.modalidad,
                    NomEmpresa = obj.nomEmpresa,
                    Puesto = obj.puesto,
                    Sueldo = obj.sueldo,
                    Tipempleo = obj.tipempleo,
                    Vacantes = obj.vacantes
                };

                db.Publicacions.Add(objPub);
                if (db.SaveChanges() == 0)
                {
                    apiResponse.msj = "No se ha podido registrar publicación";
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

        public static ApiResponse EditarPublicacion(PublicacionDt obj)
        {
            ApiResponse apiResponse = new ApiResponse();
            BDBumeranContext db = new BDBumeranContext();
            try
            {
                Publicacion objPub = db.Publicacions.Find(obj.idPublicacion);

                if (obj != null)
                {
                    objPub.Area = obj.area;
                    objPub.Descrip = obj.descrip;
                    objPub.Habilidades = obj.habilidades;
                    objPub.Jerarquia = obj.jerarquia;
                    objPub.Lugar = obj.lugar;
                    objPub.IdDepartamento = obj.idDepartamento;
                    objPub.Departamento = obj.departamento;
                    objPub.Distrito = obj.distrito;
                    objPub.Modalidad = obj.modalidad;
                    objPub.NomEmpresa = obj.nomEmpresa;
                    objPub.Puesto = obj.puesto;
                    objPub.Sueldo = obj.sueldo;
                    objPub.Tipempleo = obj.tipempleo;
                    objPub.Vacantes = obj.vacantes;

                    db.Entry(objPub).State = EntityState.Modified;
                    if (db.SaveChanges() == 0)
                    {
                        apiResponse.msj = "No se ha podido actualizar publicación";
                        apiResponse.estatus = 500;
                    }
                }
                else
                {
                    apiResponse.msj = "No se pudo encontrar datos de la publicación";
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

        public static ApiResponse EdliminarPublicacion(int id)
        {
            ApiResponse apiResponse = new ApiResponse();
            BDBumeranContext db = new BDBumeranContext();
            try
            {
                Publicacion objPub = db.Publicacions.Find(id);

                if (objPub != null)
                {
                    db.Publicacions.Remove(objPub);
                    if (db.SaveChanges() == 0)
                    {
                        apiResponse.msj = "No se ha podido eliminar publicación";
                        apiResponse.estatus = 500;
                    }
                }
                else
                {
                    apiResponse.msj = "No se pudo encontrar datos de la publicación";
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


        public static List<Publicacion> ListarPublicacion()
        {
            BDBumeranContext db = new BDBumeranContext();
            return db.Publicacions.ToList();
        }
    }
}
