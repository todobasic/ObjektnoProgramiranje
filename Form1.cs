using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingBoard
{
    public partial class Form1 : Form
    {

        Point mStartPoint;
        Point mCurrPoint;
        Color chosenColor;
        
        Pen mDrawPen;
        Graphics mGraphicsHelper;
        private const int PEN_WIDTH = 1;
        bool bMouseDown;

        private List<Point> polygonPoints = new List<Point>();

        Linija linija;
        Pravokutnik pravokut;
        Kruznica kruznica;
        Elipsa elipsa;
        Poligon poligon;
        
        List<Elipsa> listaElipsi = new List<Elipsa>();
        List<Kruznica> listaKruznica = new List<Kruznica>();
        List<Linija> listaLinija = new List<Linija>();
        List<Pravokutnik> listaPravokutnika = new List<Pravokutnik>();
        List<Poligon> listaPoligona = new List<Poligon>();


        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            this.mStartPoint = e.Location;
            this.mCurrPoint = Point.Empty;
            this.bMouseDown = true;            
            
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            this.bMouseDown = false;
            if (elipsa != null) { listaElipsi.Add(elipsa); }
            if (kruznica != null) { listaKruznica.Add(kruznica); }
            if (linija != null) { listaLinija.Add(linija); }
            if (pravokut != null) { listaPravokutnika.Add(pravokut); }
            if (poligon != null) { listaPoligona.Add(poligon); }   


        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            
            if (this.bMouseDown)
            {             
                this.mCurrPoint = e.Location;
                this.Invalidate();
            }
                
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (this.bMouseDown)
            {
                
                for (int i = 0; i < listaLinija.Count; i++)
                {
                    listaLinija[i].DrawGrafObj();                    
                }                
                for(int i = 0; i < listaPravokutnika.Count; i++)
                {                    
                    listaPravokutnika[i].DrawGrafObj();
                }
                for (int i = 0; i < listaElipsi.Count; i++)
                {
                    listaElipsi[i].DrawGrafObj();
                }
                for (int i = 0; i < listaKruznica.Count; i++)
                {
                    listaKruznica[i].DrawGrafObj();
                }
                for (int i = 0; i < listaPoligona.Count; i++)
                {
                    listaPoligona[i].DrawGrafObj();
                }


                if (radioBtn_clrBlack.Checked)
                {
                    chosenColor = Color.Black;
                }
                else if (radioBtn_clrRed.Checked)
                {
                    chosenColor = Color.Red;
                }
                else if (radioBtn_clrBlue.Checked)
                {
                    chosenColor = Color.Blue;
                }

                if (radioBtn_drwLine.Checked)
                {
                    linija = new Linija(chosenColor, mStartPoint, mCurrPoint, mGraphicsHelper);
                    linija.DrawGrafObj();

                }
                else if (radioBtn_drwRect.Checked)
                {
                    pravokut = new Pravokutnik(chosenColor, mStartPoint, mCurrPoint, mGraphicsHelper);
                    pravokut.DrawGrafObj();
                }
                else if (radioBtn_drwEllipse.Checked)
                {
                    elipsa = new Elipsa(chosenColor, mStartPoint, mCurrPoint, mGraphicsHelper);
                    elipsa.DrawGrafObj();
                }
                else if (radioBtn_drwCircle.Checked)
                {
                    kruznica = new Kruznica(chosenColor, mStartPoint, mCurrPoint, mGraphicsHelper);
                    kruznica.DrawGrafObj();
                }
                else if (radioBtn_drwPolygon.Checked)
                {
                    poligon = new Poligon(chosenColor, mStartPoint, mCurrPoint, mGraphicsHelper);
                    poligon.DrawGrafObj();
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mGraphicsHelper = this.CreateGraphics();
            mDrawPen = new Pen(Color.Red, PEN_WIDTH);

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            /*if (radioBtn_drwPolygon.Checked)
            {
                switch (e.Button)
                {
                    case MouseButtons.Left:
                        //Lijevim klikom crta se proizvoljni broj linija
                        polygonPoints.Add(new Point(e.X, e.Y));
                        if (polygonPoints.Count > 1)
                        {
                            
                            this.DrwLine(polygonPoints[polygonPoints.Count - 2], polygonPoints[polygonPoints.Count - 1]);
                        }
                        break;

                    case MouseButtons.Right:
                        //Desnim klikom se završava crtanjem poligona, odnosno spaja se zadnja tocka sa prvom
                        if (polygonPoints.Count > 2)
                        {
                            //Crta se zadnja linija
                            this.DrwLine(polygonPoints[polygonPoints.Count - 1], polygonPoints[0]);
                            polygonPoints.Clear();
                        }
                        break;
                        */
                }
            }
        }

      
    

