using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class TecnologiaCE
    {
        private string codtip;
        private string destip;
        private string durabilidad;
        private string codcat;
        private string descat;
        private string detalle;

        public string getCodtip()
        {
            return codtip;
        }

        public void setCodtip(string codtip)
        {
            this.codtip = codtip;
        }

        public string getDestip()
        {
            return destip;
        }

        public void setDestip(string destip)
        {
            this.destip = destip;
        }

        public string getDurabilidad()
        {
            return durabilidad;
        }

        public void setDurabilidad(string durabilidad)
        {
            this.durabilidad = durabilidad;
        }

        public string getCodcat()
        {
            return codcat;
        }

        public void setCodcat(string codcat)
        {
            this.codcat = codcat;
        }

        public string getDescat()
        {
            return descat;
        }

        public void setDescat(string descat)
        {
            this.descat = descat;
        }

        public string getDetalle()
        {
            return detalle;
        }

        public void setDetalle(string detalle)
        {
            this.detalle = detalle;
        }

    }
}
