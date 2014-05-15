using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Centroides.Secciones
{
    public class Punto
    {
        private double _x;
        private double _y;
        private double _z;

        public double x
        {
            get
            {
                return this._x;
            }
            set
            {
                this._x = value;
            }
        }

        public double y
        {
            get
            {
                return this._y;
            }
            set
            {
                this._y = value;
            }
        }

        public double z
        {
            get
            {
                return this._z;
            }
            set
            {
                this._z = value;
            }
        }

        public Punto(double x, double y, double z)
        {
            this._x = x;
            this._y = y;
            this._z = z;
        }

        public void SumarVector(double DeltaX, double DeltaY, double DeltaZ)
        {
            this._x = this._x + DeltaX;
            this._y = this._y + DeltaY;
            this._z = this._z + DeltaZ;
        }

        public override string ToString()
        {
            return "x = " + this._x.ToString() + "  y = " + this._y.ToString() + "  z = " + this._z.ToString();
        }
    }
}
