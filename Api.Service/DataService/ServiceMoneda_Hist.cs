using Api.Context;
using Api.Model.Modelos;
using Api.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Service.DataService
{
    public class ServiceMoneda_Hist
    {
        private ConexionDbContext _db = new ConexionDbContext();

        public ServiceMoneda_Hist()
        {            
        }
   
        /// <summary>
        /// obtener el tipo de cambio del dia
        /// </summary>
        /// <returns></returns>
        public async Task<Moneda_Hist> ObtenerTipoCambioDelDiaAsync(ResponseModel responseModel)
        {
            //clase para obtener el tipo de cambio del dia
            var tipoCambio = new Moneda_Hist();
            try
            {
                //tipoCambio = await _db.Moneda_Hist.Where(tc => tc.Fecha == DateTime.Now.Date).FirstOrDefaultAsync();
                //si el objeto tipoCambio no tiene registro
                if(tipoCambio != null)
                {
                    responseModel.Exito = 1;
                    responseModel.Mensaje = "Consulta Exitosa";
                }
                else
                {
                    responseModel.Exito = 0;
                    responseModel.Mensaje = "El Tipo de cambio del dia no existe en la base de datos";
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tipoCambio;
        }
    }
}
