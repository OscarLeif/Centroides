using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using Centroides.Secciones;

namespace SeccionesForms
{
    public partial class PropiedadesGeometricasFromDock : DockContent
    {

        private clsVistaPropiedades _VistaPropiedades = new clsVistaPropiedades();
        //private IContainer components = (IContainer)null;
        private PropertyGrid pgdPropsGeom;

        public PropiedadesGeometricasFromDock()
        {

            InitializeComponent();

        }
        public void Actualizar(Polygon PoligonoSeleccionado)
        {
            PoligonoSeleccionado.CalcularPropiedadesGeometricas();
            this._VistaPropiedades.PoligonoAMostrar = PoligonoSeleccionado;
            actualizarPropertyGrid();
        }

        public void actualizarPropertyGrid()
        {
            // Create an example collection.
            var dictionary = new Dictionary<string, string>();
            //String area = Convert.ToString(poligono.Area);
            //String momentoX = Convert.ToString(poligono.Mx);
            //String momentoY = Convert.ToString(poligono.My);

            dictionary.Add("cat", "blue");
            dictionary.Add("dog", "green");
            // Assign SelectedObject.
            propertyGrid1.SelectedObject = _VistaPropiedades;
        }
    }


}
