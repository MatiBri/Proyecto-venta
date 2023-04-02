using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVenta {
    class Venta {
        int nroVenta;
        string articulo;
        double precio;
        int cantidad;

        public int pNroVenta
        {
        set { nroVenta = value; }
        get { return nroVenta; }
        }

        public string pArticulo {
            set { articulo = value; }
            get { return articulo; }
        }

        public double  pPrecio {
            set { precio = value; }
            get { return precio; }
        }

        public int pCantidad {
            set { cantidad = value; }
            get { return cantidad; }
        }
    
        public Venta()
        {
            nroVenta = 0;
            articulo = "";
            precio = 0;
            cantidad = 0;
        }
        public Venta(int nroV, string art, double pre, int cant)
        {
            nroVenta = nroV;
            articulo = art;
            precio = pre;
            cantidad = cant;
        }

        public double calcularMonto()
        {
            return precio * Convert.ToDouble(cantidad);
        }

        public string toStringVenta()
        {
        return "Venta Nro.: " + Convert.ToString(nroVenta)+ "\n" +
                "Artículo: " + articulo + "\n" +
                "Precio unitario: " + Convert.ToString(precio) + "\n" +
                "Cantidad: " + Convert.ToString(cantidad) + "\n" +
                "Monto: " + Convert.ToString(calcularMonto());
        }
    }

}
