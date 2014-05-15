using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Centroides.Secciones;
using System.ComponentModel;

namespace SeccionesForms
{
    public class clsVistaPropiedades
    {
        public bool opcion = true;
        public Polygon PoligonoAMostrar;

        [DisplayName("Descripción")]
        [Description("Texto descriptivo del área seleccionada.")]
        [Category("Descriptivas")]
        public string Descripcion
        {
            get
            {
                return this.PoligonoAMostrar.Descripcion;
            }
            set
            {
                this.PoligonoAMostrar.Descripcion = value;
            }
        }

        [Category("Descriptivas")]
        [DisplayName("Información")]
        [Description("Información adicional del área seleccionada.")]
        public string Informacion
        {
            get
            {
                return this.PoligonoAMostrar.Informacion;
            }
            set
            {
                this.PoligonoAMostrar.Informacion = value;
            }
        }

        [Description("Area de la superficie encerrada por el poligono que define la sección (cm\x00B2, m\x00B2, pulg\x00B2, pie\x00B2)")]
        [DisplayName("Area")]
        [Category("Generales")]
        public double Area
        {
            get
            {
                return this.PoligonoAMostrar.Area;
            }
        }

        [Description("Coordenada X del centro de gravedad del polígono (cm, m, pulg, pie)")]
        [DisplayName("X (cg)")]
        [Category("Generales")]
        public double Xcg
        {
            get
            {
                return this.PoligonoAMostrar.Xcg;
            }
        }

        [Description("Coordenada Y del centro de gravedad del polígono (cm, m, pulg, pie)")]
        [Category("Generales")]
        [DisplayName("Y (cg)")]
        public double Ycg
        {
            get
            {
                return this.PoligonoAMostrar.Ycg;
            }
        }

        [Description("Momento de inercia del polígono respecto al eje X del centro de gravedad (cm4, m4, pulg4, pie4)")]
        [Category("Respecto al Centro de Gravedad")]
        [DisplayName("Inercia XX (cg)")]
        public double InerciaXX_cg
        {
            get
            {
                return this.PoligonoAMostrar.InerciaXX_cg;
            }
        }

        [Description("Momento de inercia del polígono respecto al eje Y del centro de gravedad (cm4, m4, pulg4, pie4)")]
        [DisplayName("Inercia YY (cg)")]
        [Category("Respecto al Centro de Gravedad")]
        public double InerciaYY_cg
        {
            get
            {
                return this.PoligonoAMostrar.InerciaYY_cg;
            }
        }

        [Category("Respecto al Centro de Gravedad")]
        [Description("Producto de inercia del polígono respecto al centro de gravedad (cm4, m4, pulg4, pie4)")]
        [DisplayName("Producto de Inercia (cg)")]
        public double PXY_cg
        {
            get
            {
                return this.PoligonoAMostrar.PXY_cg;
            }
        }

        [Category("Respecto al Centro de Gravedad")]
        [DisplayName("Momento Polar de Inercia Jo (cg)")]
        [Description("Momento polar de inercia del polígono respecto a los ejes del centro de gravedad (cm4, m4, pulg4, pie4)")]
        public double Jo_cg
        {
            get
            {
                return this.PoligonoAMostrar.Jo_cg;
            }
        }

        [Description("Radio de giro del polígono respecto al eje X del centro de gravedad (cm, m, pulg, pie)")]
        [Category("Respecto al Centro de Gravedad")]
        [DisplayName("Radio de Giro X (cg)")]
        public double Kx_cg
        {
            get
            {
                return this.PoligonoAMostrar.Kx_cg;
            }
        }

        [Description("Radio de giro del polígono respecto al eje Y del centro de gravedad (cm, m, pulg, pie)")]
        [DisplayName("Radio de Giro Y (cg)")]
        [Category("Respecto al Centro de Gravedad")]
        public double Ky_cg
        {
            get
            {
                return this.PoligonoAMostrar.Ky_cg;
            }
        }

        [Category("Respecto a los ejes XY")]
        [Description("Momento de inercia del polígono respecto al eje X (cm4, m4, pulg4, pie4)")]
        [DisplayName("Inercia XX")]
        public double InerciaXX
        {
            get
            {
                return this.PoligonoAMostrar.InerciaXX;
            }
        }

        [Description("Momento de inercia del polígono respecto al eje Y (cm4, m4, pulg4, pie4)")]
        [Category("Respecto a los ejes XY")]
        [DisplayName("Inercia YY")]
        public double InerciaYY
        {
            get
            {
                return this.PoligonoAMostrar.InerciaYY;
            }
        }

        [Category("Respecto a los ejes XY")]
        [Description("Producto de inercia del polígono respecto a los ejes XY (cm4, m4, pulg4, pie4)")]
        [DisplayName("Producto de Inercia")]
        public double PXY
        {
            get
            {
                return this.PoligonoAMostrar.PXY;
            }
        }

        [Category("Respecto a los ejes XY")]
        [DisplayName("Momento Polar de Inercia Jo")]
        [Description("Momento polar de inercia del polígono respecto a los ejes XY (cm4, m4, pulg4, pie4)")]
        public double Jo
        {
            get
            {
                return this.PoligonoAMostrar.Jo;
            }
        }

        [DisplayName("Radio de Giro X")]
        [Category("Respecto a los ejes XY")]
        [Description("Radio de giro del polígono respecto al eje X (cm, m, pulg, pie)")]
        public double Kx
        {
            get
            {
                return this.PoligonoAMostrar.Kx;
            }
        }

        [Description("Radio de giro del polígono respecto al eje Y (cm, m, pulg, pie)")]
        [DisplayName("Radio de Giro Y")]
        [Category("Respecto a los ejes XY")]
        public double Ky
        {
            get
            {
                return this.PoligonoAMostrar.Ky;
            }
        }

        [Description("Momento del polígono respecto al eje X (cm\x00B3, m\x00B3, pulg\x00B3, pie\x00B3)")]
        [Category("Respecto a los ejes XY")]
        [DisplayName("Momento X")]
        public double Mx
        {
            get
            {
                return this.PoligonoAMostrar.Mx;
            }
        }

        [Description("Momento del polígono respecto al eje Y (cm\x00B3, m\x00B3, pulg\x00B3, pie\x00B3)")]
        [Category("Respecto a los ejes XY")]
        [DisplayName("Momento Y")]
        public double My
        {
            get
            {
                return this.PoligonoAMostrar.My;
            }
        }
    }
}
