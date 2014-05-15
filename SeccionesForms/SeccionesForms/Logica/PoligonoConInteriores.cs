using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centroides.Secciones
{
    public class PoligonoConInteriores : Polygon
    {
        protected List<Polygon> _PoligonosInternos = new List<Polygon>();

        public List<Polygon> PoligonosInternos
        {
            get
            {
                return this._PoligonosInternos;
            }
            set
            {
                this._PoligonosInternos = value;
            }
        }

        public override void SumarVector(double DeltaX, double DeltaY, double DeltaZ)
        {
            base.SumarVector(DeltaX, DeltaY, DeltaZ);
            foreach (Polygon poligono in this._PoligonosInternos)
                poligono.SumarVector(DeltaX, DeltaY, DeltaZ);
        }

        public override void CalcularPropiedadesGeometricas()
        {
            try
            {
                base.CalcularPropiedadesGeometricas();
                if (!this.EsEstable)
                    return;
                foreach (Polygon poligono in this._PoligonosInternos)
                {
                    if (poligono.EsEstable && poligono.EsActivo)
                    {
                        poligono.CalcularPropiedadesGeometricas();
                        this._Area = this._Area - poligono.Area;
                        this._Mx = this._Mx - poligono.Mx;
                        this._My = this._My - poligono.My;
                        this._InerciaXX = this._InerciaXX - poligono.InerciaXX;
                        this._InerciaYY = this._InerciaYY - poligono.InerciaYY;
                        this._PXY = this._PXY - poligono.PXY;
                    }
                }
                this._Xcg = this._My / this._Area;
                this._Ycg = this._Mx / this._Area;
                this._InerciaXX_cg = this._InerciaXX - this._Area * Math.Pow(this._Ycg, 2.0);
                this._InerciaYY_cg = this._InerciaYY - this._Area * Math.Pow(this._Xcg, 2.0);
                this._PXY_cg = this._PXY - this._Area * this._Xcg * this._Ycg;
                this._Jo = this._InerciaXX + this._InerciaYY;
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
