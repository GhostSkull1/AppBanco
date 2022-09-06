using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBanco
{
    class Cliente
    {
        public string nombre;
        private int monto;
        public Cliente(string nom)
        {
            nombre = nom;
            monto = 0;
        }
        public void depositar(int mnt)
        {
            monto += mnt;
        }

        public void retirar(int mnt)
        {
            monto -= mnt;
        }
        class Banco
        {
            Cliente cliente1, cliente2, cliente3;
            
                public Banco()
            {
                Console.WriteLine("ingrese el nombre del cliente 1:");
                cliente1 = new Cliente(Console.ReadLine());
                Console.WriteLine("ingrese el nombre del cliente 2:");
                cliente2 = new Cliente(Console.ReadLine()); 
                Console.WriteLine("ingrese el nombre del cliente 3:");
                cliente3 = new Cliente(Console.ReadLine());
            }

            public void Operar()
            {
                string nombrecliente;
                Console.WriteLine("nombre del cliente es: " + cliente1.nombre);
                nombrecliente = Console.ReadLine();
                if (nombrecliente == cliente1.nombre)
                {
                    Console.WriteLine("bienvenido señor(a)" + cliente1.nombre);
                }
                else if (nombrecliente == cliente2.nombre)
                {
                    Console.WriteLine("bienvenido señor(a)" + cliente2.nombre);
                }
                else if (nombrecliente == cliente3.nombre)
                {
                    Console.WriteLine("bienvenido señor(a)" + cliente3.nombre);
                }
                else
                {
                    Console.WriteLine("usuario no registrado");
                }

                
            }
        }
        static void Main(string[] args)
        {
            Banco bnk = new Banco();
            bnk.Operar();   
            Console.ReadKey();
        }
    }
}
//nnnnnnnnnnnnnnnnnnnnn