using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centroides.Secciones
{
    public interface IGeometricProperties
    {
        double Area { get; }

        double Xcg { get; }

        double Ycg { get; }

        double InerciaXX_cg { get; }

        double InerciaYY_cg { get; }

        double PXY_cg { get; }

        double Jo_cg { get; }

        double Kx_cg { get; }

        double Ky_cg { get; }

        double InerciaXX { get; }

        double InerciaYY { get; }

        double PXY { get; }

        double Jo { get; }

        double Kx { get; }

        double Ky { get; }

        double Mx { get; }

        double My { get; }
    }
}
