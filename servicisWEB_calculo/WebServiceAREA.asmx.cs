using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace servicisWEB_calculo
{
    /// <summary>
    /// Descripción breve de WebServiceAREA
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceAREA : System.Web.Services.WebService
    {

        [WebMethod(Description = "metodo de dar la bienvenida")]
        public string CREADOR()
        {
            return "CREADO: CLAUDIA NAYELI GONZALEZ CUNDAPI";
        }
        [WebMethod(Description = "Area de un cuadrado")]
        public int CUADRADO(int LADO)
        {
            return LADO * LADO;
        }
        [WebMethod(Description = "Area de un Triangulo")]
        public int TRIANGULO(int BASE, int ALTURA)
        {
            return BASE * ALTURA / 2;
        }
        /// <summary>
        /// Aqui creamos el area del circulo donde declare un double para calcular el PI que es 3.1416
        /// </summary>
        /// <param name="Radio"></param>
        /// <returns></returns>
        [WebMethod(Description = "Area de un Circulo")]
        public double CIRCULO(double RADIO)
        {
            return 3.1416 * RADIO * RADIO;
        }
    }
}
