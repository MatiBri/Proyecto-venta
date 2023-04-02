using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoVenta {
    public partial class frmVenta : Form
    {

        int c; //definimos contador de ventas
        double acu; //definimos acumulador de montos
        int cParcial; //Definimos contador parcial. Contado de articulos con precio mayor a 100
        double montoMen;
        int nroVentaMen;
        int b;
        public frmVenta()
        {
            InitializeComponent();
            c= 0;
            acu = 0;
            cParcial = 0;
            b = 0;
            montoMen = 0;
            nroVentaMen = 0;
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Venta V = new Venta();
       
            V.pNroVenta = Convert.ToInt32(txtNroVenta.Text);
            V.pArticulo = txtArticulo.Text;
            V.pPrecio = Convert.ToDouble(txtPrecio.Text);
            V.pCantidad = Convert.ToInt32(txtCantidad.Text);
            txtMonto.Text = Convert.ToString(V.calcularMonto());
         
            MessageBox.Show(V.toStringVenta());

            c = c + 1; //Incrementamos contador: Contador "c" va a valer c = c + 1 donde va a contar por 1 cada vez que se use. Cuenta Ventas
            txtCantVta.Text = Convert.ToString(c);

            acu = acu + V.calcularMonto(); //Acumulador "acu = acu + V.calcularMonto(); Acumulador es una sumatoria de los totales que en este caso se usa el acumulador "acu" para acumular las ventas. Acumula montos 
            txtMontoTotal.Text = Convert.ToString(acu);

            txtVentaPromedio.Text = Convert.ToString(acu / Convert.ToDouble(c)); /*Acá se hace acumulador sobre contador pero donde el contador es convertido a Double tal y como está el acumulador
            y todo eso se pasa a tipo String que queda como texto desplegado en el Form, es por eso que en "Convert.ToDouble(c)". C es el valor que representa el contador que se pasa de int a double*/




            //Calcular un porcentaje

            //CParcial * 100/ CTotal -> Contador parcial por 100 sobre contador total
            //Ctotal --> 100
            //Cparcial ----> CParcial * 100/ Ctotal

            if (V.pPrecio>100)
            {
                cParcial = cParcial + 1;

            }

            txtPorcentaje.Text = Convert.ToString(cParcial * 100 / c); //Acá se aplica el contador parcial por 100 sobre el contador total "c" y todo se pasa a ToString para resolverse en el Form el .Text de la propiedad Text

            //nro de venta de la de menor monto
            if(b==0) //pregunta si la bandera es cero(nro Venta)
            { //si es verdadero guarda el monto y el nro(número) de venta
                montoMen = V.calcularMonto();
                nroVentaMen = V.pNroVenta;
                b = 1; //B cambia su valor a 1
            }
            else if (V.calcularMonto()< montoMen)
            {
                montoMen = V.calcularMonto();//Metodo calcular monto, cuidado con los parentesis. No es lo mismo que pNroVenta, éste es un set y get. No un método
                nroVentaMen = V.pNroVenta;

            }
            txtMenorVenta.Text = Convert.ToString(nroVentaMen);
        }
        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
         
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void frmVenta_Load(object sender, EventArgs e)
        {

        }
    }
}
