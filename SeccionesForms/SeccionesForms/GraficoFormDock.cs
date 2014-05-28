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
using ZedGraph;
using System.Drawing.Drawing2D;

namespace SeccionesForms
{
    public partial class GraficoFormDock : DockContent
    {

        #region atributes
        //private IContainer components = (IContainer)null;
        private Polygon _PoligSeleccionado {get; set;}
        private PoligonoConInteriores _PoligPrincipal;
        private FormPrincipal formPrincipal;
        #endregion



        public GraficoFormDock(FormPrincipal formPrincipal)
        {
            // TODO: Complete member initialization
            this.formPrincipal = formPrincipal;
            InitializeComponent();
            zedGraphControl1.GraphPane.YAxis.Cross = 0.0;
            zedGraphControl1.GraphPane.AxisChange();
            this.zedGraphControl1.GraphPane.Title.Text = "Centroides";
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this._PoligSeleccionado = formPrincipal._PolygonoPrincipal;
            this._PoligPrincipal = new PoligonoConInteriores();
            _PoligPrincipal = (PoligonoConInteriores)formPrincipal._PolygonoPrincipal;
        }

        public void ActualizarVistaGrafica()
        {
            //Pasare los datos de un objeto al otro hasta lograrlo
            _PoligPrincipal = new PoligonoConInteriores();
            _PoligPrincipal.Puntos = formPrincipal._PolygonoPrincipal.Puntos;
            GraphPane graphPane = this.zedGraphControl1.GraphPane;
            graphPane.CurveList.Clear();
            if (this._PoligPrincipal.Puntos.Count > 0)
            {
                PointPairList pointPairList = new PointPairList();
                foreach (Punto current in this._PoligPrincipal.Puntos)
                {
                    pointPairList.Add(current.x, current.y);
                }
                pointPairList.Add(pointPairList[0]);
                LineItem lineItem = graphPane.AddCurve("Externo", pointPairList, Color.DarkBlue, SymbolType.Default);
                lineItem.Symbol.Fill = new Fill(Color.White);
                lineItem.Symbol.Size = 4f;
                lineItem.Line.Width = 2f;
            }
            foreach (Polygon current2 in this._PoligPrincipal.PoligonosInternos)
            {
                if (current2.Puntos.Count > 0)
                {
                    PointPairList pointPairList2 = new PointPairList();
                    foreach (Punto current in current2.Puntos)
                    {
                        pointPairList2.Add(current.x, current.y);
                    }
                    pointPairList2.Add(pointPairList2[0]);
                    LineItem lineItem2 = graphPane.AddCurve("Interno", pointPairList2, Color.Blue, SymbolType.Default);
                    lineItem2.Line.Width = 1f;
                    lineItem2.Line.Style = DashStyle.Dash;
                    lineItem2.Symbol.Fill = new Fill(Color.White);
                    lineItem2.Symbol.Size = 4f;
                }
            }
            if (this._PoligPrincipal.EsEstable)
            {
                this.DibujarCentroide(this._PoligPrincipal, Color.DarkBlue, 10f);
            }
            foreach (Polygon current2 in this._PoligPrincipal.PoligonosInternos)
            {
                this.DibujarCentroide(current2, Color.Blue, 5f);
            }
            graphPane.XAxis.MajorGrid.IsVisible = true;
            graphPane.YAxis.MajorGrid.IsVisible = true;
            graphPane.Legend.IsVisible = false;
            graphPane.XAxis.MinorGrid.IsVisible = true;
            graphPane.XAxis.MajorGrid.IsVisible = true;
            graphPane.YAxis.MinorGrid.IsVisible = true;
            graphPane.YAxis.MajorGrid.IsVisible = true;
            graphPane.YAxis.MajorGrid.IsZeroLine = true;
            graphPane.XAxis.MajorGrid.IsZeroLine = true;
            graphPane.Title.IsVisible = false;
            graphPane.XAxis.Title.IsVisible = false;
            graphPane.YAxis.Title.IsVisible = false;
            graphPane.IsFontsScaled = false;
            graphPane.XAxis.Color = Color.DarkGray;
            graphPane.YAxis.Color = Color.DarkGray;
            graphPane.XAxis.MajorTic.Color = Color.DarkGray;
            graphPane.YAxis.MajorTic.Color = Color.DarkGray;
            graphPane.XAxis.MinorTic.Color = Color.DarkGray;
            graphPane.YAxis.MinorTic.Color = Color.DarkGray;
            graphPane.XAxis.MinorGrid.Color = Color.DarkGray;
            graphPane.XAxis.MajorGrid.Color = Color.DarkGray;
            graphPane.YAxis.MinorGrid.Color = Color.DarkGray;
            graphPane.YAxis.MajorGrid.Color = Color.DarkGray;
            graphPane.Y2Axis.IsVisible = false;
            graphPane.Y2Axis.Color = Color.DarkGray;
            graphPane.Fill.IsScaled = true;
            graphPane.Chart.Fill.IsVisible = false;
            this.zedGraphControl1.IsShowHScrollBar = true;
            this.zedGraphControl1.IsShowVScrollBar = true;
            this.zedGraphControl1.IsAutoScrollRange = true;
            this.zedGraphControl1.IsScrollY2 = true;
            this.zedGraphControl1.IsShowPointValues = true;
            this.zedGraphControl1.AxisChange();
            this.zedGraphControl1.Invalidate();

        }

        public void DibujarCentroide(Polygon Pol, Color color, float Tamanio)
        {
            if (Pol.EsEstable)
            {
                Pol.CalcularPropiedadesGeometricas();
                PointPairList pointPairList = new PointPairList();
                string tag = string.Concat(new string[]
				{
					"Centroide (",
					Pol.Xcg.ToString(),
					" , ",
					Pol.Ycg.ToString(),
					")"
				});
                pointPairList.Add(Pol.Xcg, Pol.Ycg, tag);
                LineItem lineItem = this.zedGraphControl1.GraphPane.AddCurve("", pointPairList, color, SymbolType.Circle);
                lineItem.Symbol.Size = Tamanio;
                lineItem.Symbol.Fill = new Fill(color);
            }
        }
        //public void ResaltarCurva(Polygon PoligSeleccionado, PoligonoConInteriores PoligPrincipal)
        public void ResaltarCurva()
        {
            try
            {
                this._PoligSeleccionado = _PoligSeleccionado;
                this._PoligPrincipal = _PoligPrincipal;
                this.ActualizarVistaGrafica();
                LineItem lineItem;
                if (this._PoligSeleccionado is PoligonoConInteriores)
                {
                    lineItem = (LineItem)this.zedGraphControl1.GraphPane.CurveList[0];
                    this.DibujarCentroide(this._PoligSeleccionado, Color.Red, 13f);
                }
                else
                {
                    int num = this._PoligPrincipal.PoligonosInternos.IndexOf(this._PoligSeleccionado);
                    lineItem = (LineItem)this.zedGraphControl1.GraphPane.CurveList[num + 1];
                    this.DibujarCentroide(this._PoligSeleccionado, Color.Red, 8f);
                }
                lineItem.Line.Color = Color.Red;
                lineItem.Line.Width = 2f;
                this.zedGraphControl1.Invalidate();
            }
            catch (Exception)
            {
            }
        }
       
    }
}
