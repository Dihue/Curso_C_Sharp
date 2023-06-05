using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Ejemplo_Avisos
{
    internal class AvisosTrafico : IAvisos
    {
        // Campos de la clase
        private String remitente;
        private String mensaje;
        private String fecha;

        // Constructores
        public AvisosTrafico()
        {
            remitente = "DGT";
            mensaje = "Sanción cometida";
            fecha = "";
        }

        public AvisosTrafico(String remitente, String mensaje, String fecha)
        {
            this.remitente = remitente;
            this.mensaje = mensaje;
            this.fecha = fecha;
        }

        // Métodos que vienen de la interface
        public string GetFecha()
        {
            return fecha;
        }

        public void MostrarAviso()
        {
            Console.WriteLine("Mensaje {0} ha sido enviado por {1} el día {2}",
                mensaje, remitente, fecha);
        }
    }
}
