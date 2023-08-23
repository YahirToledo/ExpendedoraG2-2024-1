using System;
using System.Threading;

namespace ExpendedoraG2_2024_1
{
    internal class Expendedora
    {
        #region Atributos
        private string marca;
        private ushort cantproductos;
        private byte temperatura;
        private float precio;


        #endregion

        #region Propiedades
        public byte Temperatura 
        {
            get => temperatura;//get lectura
            set 
            {
                if (0 < value && value < 25) 
                    temperatura = value;//limites de escritura
                else
                    temperatura = 20;
            } 
        }
        #endregion

        #region Metodos
        private void Saludar()
        {
            Console.WriteLine("Bienvenido! Elige un producto");
        }
        private void LimpiarDisplay()
        {
            Thread.Sleep(2000);
            Console.Clear();
        }
        public string MostrarProducto()
        {
            Console.WriteLine("3A: Doritos \n3B: Churrumais ");
            Console.WriteLine("Ingresa el codigo del producto");
            string codigo = Console.ReadLine(); //En las variables locales hay que siempre inicializar un valor
            return codigo;
        }
        public void MostrarPrecio(string codigo)
        {
            switch (codigo)
            {
                case "3A":
                    Console.WriteLine("Precio: ${0}", precio);
                    break;
                case "3B":
                    Console.WriteLine("Precio: ${0}", precio-6);
                    break;
                default:
                    Console.WriteLine("No ingresaste un producto valido");
                    break;
            }
        }

        #endregion

        #region Constructor
        public Expendedora()
        {
            marca = "AMS";
            precio = 18;
            Saludar();
            LimpiarDisplay();
            Console.WriteLine("Marca: {0}", marca);
            LimpiarDisplay();
            string codigo = MostrarProducto();
            LimpiarDisplay();
            MostrarPrecio(codigo);
        }

        //Sobrecargar un metodo
        public Expendedora(bool Mantenimiento)
        {
            Temperatura = 20;
            if (Mantenimiento == true)
                Console.WriteLine("Entrando en modo mantenimiento");
            Console.WriteLine("Cambiando temperatura");
            LimpiarDisplay();
            for (int i = 0; i < 20; i++)
            {
                Temperatura++;
            }
            Console.WriteLine("Mostrando temperatura {0} [°C]", Temperatura);
        }
        #endregion
    }
}
