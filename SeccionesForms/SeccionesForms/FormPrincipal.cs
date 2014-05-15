using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;
using Centroides.Secciones;

namespace SeccionesForms
{
    public partial class FormPrincipal : Form
    {
        public Polygon _PolygonoPrincipal;
        public puntosForm formPuntos;
        public GraficoFormDock formGrafico;
        public PropiedadesGeometricasFromDock formProp;
        
        public FormPrincipal()
        {
            InitializeComponent();
            formGrafico = new GraficoFormDock(this);
            formPuntos = new puntosForm(this);
            formProp = new PropiedadesGeometricasFromDock();
            _PolygonoPrincipal = new Polygon();
        }
        //private ZedGraph.ZedGraphControl zg1;
        
        private void Form1_Load(object sender, EventArgs e)
        {

            formPuntos.Show(dockPanel, WeifenLuo.WinFormsUI.Docking.DockState.DockLeft);
            formGrafico.Show(dockPanel, WeifenLuo.WinFormsUI.Docking.DockState.Document);
            formProp.Show(dockPanel, WeifenLuo.WinFormsUI.Docking.DockState.DockRight);

            graficarPunto(0,0);
        }

        private void graficarPunto(double X,double Y)
        {
            ZedGraph.PointObj point = new ZedGraph.PointObj(5, 5, 50, 50, ZedGraph.SymbolType.Square, Color.Green);
 ZedGraph.PaneBase paneBase = formGrafico.zedGraphControl1.GraphPane;
 point.Fill = new ZedGraph.Fill(Color.Green);
 System.Drawing.Graphics graphics = formGrafico.zedGraphControl1.CreateGraphics();

 // Draw point to graph
 point.Draw(graphics, paneBase, paneBase.CalcScaleFactor());

 // Re-draw graph, but point only flashes momentarily. 
 formGrafico.zedGraphControl1.Invalidate();

        }

        private void zedGraphControl1_Load(object sender, EventArgs e)
        {
           

        }
    }
}
