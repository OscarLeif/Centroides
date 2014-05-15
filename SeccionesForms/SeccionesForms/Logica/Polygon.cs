using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centroides.Secciones
{
    public class Polygon
    {
        #region Atributes
        private List<Punto> _Puntos = new List<Punto>();
        private string _Descripcion = "";
        private bool _EsActivo = true;
        private string _Informacion = "";
        private bool _EsEstable;
        protected double _Area;
        protected double _Xcg;
        protected double _Ycg;
        protected double _InerciaXX_cg;
        protected double _InerciaYY_cg;
        protected double _PXY_cg;
        protected double _Jo_cg;
        protected double _Kx_cg;
        protected double _Ky_cg;
        protected double _InerciaXX;
        protected double _InerciaYY;
        protected double _PXY;
        protected double _Jo;
        protected double _Kx;
        protected double _Ky;
        protected double _Mx;
        protected double _My;
        #endregion

        #region getters & setters
        public List<Punto> Puntos
        {
            get
            {
                return this._Puntos;
            }
            set
            {
                this._Puntos = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return this._Descripcion;
            }
            set
            {
                this._Descripcion = value;
            }
        }

        public string Informacion
        {
            get
            {
                return this._Informacion;
            }
            set
            {
                this._Informacion = value;
            }
        }

        public bool EsEstable
        {
            get
            {
                this._EsEstable = this._Puntos.Count >= 3;
                return this._EsEstable;
            }
        }

        public bool EsActivo
        {
            get
            {
                return this._EsActivo;
            }
            set
            {
                this._EsActivo = value;
            }
        }

        public double Area
        {
            get
            {
                return this._Area;
            }
        }

        public double Xcg
        {
            get
            {
                return this._Xcg;
            }
        }

        public double Ycg
        {
            get
            {
                return this._Ycg;
            }
        }

        public double InerciaXX_cg
        {
            get
            {
                return this._InerciaXX_cg;
            }
        }

        public double InerciaYY_cg
        {
            get
            {
                return this._InerciaYY_cg;
            }
        }

        public double PXY_cg
        {
            get
            {
                return this._PXY_cg;
            }
        }

        public double Jo_cg
        {
            get
            {
                return this._Jo_cg;
            }
        }

        public double Kx_cg
        {
            get
            {
                return this._Kx_cg;
            }
        }

        public double Ky_cg
        {
            get
            {
                return this._Ky_cg;
            }
        }

        public double InerciaXX
        {
            get
            {
                return this._InerciaXX;
            }
        }

        public double InerciaYY
        {
            get
            {
                return this._InerciaYY;
            }
        }

        public double PXY
        {
            get
            {
                return this._PXY;
            }
        }

        public double Jo
        {
            get
            {
                return this._Jo;
            }
        }

        public double Kx
        {
            get
            {
                return this._Kx;
            }
        }

        public double Ky
        {
            get
            {
                return this._Ky;
            }
        }

        public double Mx
        {
            get
            {
                return this._Mx;
            }
        }

        public double My
        {
            get
            {
                return this._My;
            }
        }
        #endregion


        protected void InicializarPropiedades()
        {
            this._Area = 0.0;
            this._Xcg = 0.0;
            this._Ycg = 0.0;
            this._InerciaXX_cg = 0.0;
            this._InerciaYY_cg = 0.0;
            this._PXY_cg = 0.0;
            this._Jo_cg = 0.0;
            this._Kx_cg = 0.0;
            this._Ky_cg = 0.0;
            this._InerciaXX = 0.0;
            this._InerciaYY = 0.0;
            this._PXY = 0.0;
            this._Jo = 0.0;
            this._Kx = 0.0;
            this._Ky = 0.0;
            this._Mx = 0.0;
            this._My = 0.0;
        }
        public virtual void SumarVector(double DeltaX, double DeltaY, double DeltaZ)
        {
            foreach (Punto punto in this._Puntos)
                punto.SumarVector(DeltaX, DeltaY, DeltaZ);
        }

        public virtual void CalcularPropiedadesGeometricas()
        {
            try
            {
                this.InicializarPropiedades();
                double num1 = 0.0;
                double num2 = 0.0;
                double num3 = 0.0;
                double num4 = 0.0;
                double num5 = 0.0;
                double num6 = 0.0;
                if (!this.EsEstable)
                    return;
                this._Puntos.Add(this._Puntos[0]);
                for (int index = 0; index < this._Puntos.Count - 1; ++index)
                {
                    double x1 = this._Puntos[index].x;
                    double x2 = this._Puntos[index + 1].x;
                    double y1 = this._Puntos[index].y;
                    double y2 = this._Puntos[index + 1].y;
                    double num7 = (x1 * y2 - x2 * y1) / 2.0;
                    num1 += num7;
                    num2 += (y1 + y2) * num7 / 3.0;
                    num3 += (x1 + x2) * num7 / 3.0;
                    num4 += (y1 * y1 + y2 * y2 + y1 * y2) * num7 / 6.0;
                    num5 += (x1 * x1 + x2 * x2 + x1 * x2) * num7 / 6.0;
                    num6 += (x1 * y1 + x2 * y2 + (x1 * y2 + x2 * y1) / 2.0) * num7 / 6.0;
                }
                //this.Puntos.RemoveAt(this.Puntos.Count - 1);
                _Puntos.RemoveAt(_Puntos.Count - 1);
                int num8 = num1 <= 0.0 ? -1 : 1;
                this._Area = (double)num8 * num1;
                this._Mx = (double)num8 * num2;
                this._My = (double)num8 * num3;
                this._Xcg = this._My / this._Area;
                this._Ycg = this._Mx / this._Area;
                this._InerciaXX = Math.Abs(num4);
                this._InerciaYY = Math.Abs(num5);
                this._PXY = (double)num8 * num6;
                this._Jo = this._InerciaXX + this._InerciaYY;
                this._InerciaXX_cg = this._InerciaXX - this._Area * Math.Pow(this._Ycg, 2.0);
                this._InerciaYY_cg = this._InerciaYY - this._Area * Math.Pow(this._Xcg, 2.0);
                this._PXY_cg = this._PXY - this._Area * this._Xcg * this._Ycg;
                this._Jo_cg = this._InerciaXX_cg + this._InerciaYY_cg;
                this._Kx = Math.Sqrt(this._InerciaXX / this._Area);
                this._Ky = Math.Sqrt(this._InerciaYY / this._Area);
                this._Kx_cg = Math.Sqrt(this._InerciaXX_cg / this._Area);
                this._Ky_cg = Math.Sqrt(this._InerciaYY_cg / this._Area);
            }
            catch (Exception ex)
            {
                this.InicializarPropiedades();
                throw ex;
            }
        }
    }
}
