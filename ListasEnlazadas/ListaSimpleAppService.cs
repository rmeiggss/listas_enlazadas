using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasEnlazadas
{
    public class ListaSimpleAppService
    {
        private Nodo Raiz;
        private Nodo Nuevo;
        private Nodo Puntero;
        private Nodo Anterior;

        public ListaSimpleAppService()
        {
            Raiz = null;
        }

        public void InsertarLIFO(int dato)
        {
            Nuevo = new Nodo();
            Nuevo.Info = dato;
            if (this.Raiz == null)
            {
                Nuevo.Sig = null;
            }
            else
            {
                Nuevo.Sig = Raiz;
            }
            Raiz = Nuevo;
        }
        public void InsertarFIFO(int dato)
        {
            Nuevo = new Nodo();
            Nuevo.Info = dato;
            if (this.Raiz == null)
            {
                Nuevo.Sig = null;
                Raiz = Anterior = Nuevo;
            }
            else
            {
                Anterior.Sig = Nuevo;
                Nuevo.Sig = null;
                Anterior = Nuevo;
            }
        }

        public void Recorrido()
        {
            if(Raiz != null)
            {
                Puntero = Raiz;
                while (Puntero != null)
                {
                    Console.WriteLine(Puntero!.Info);
                    Puntero = Puntero!.Sig;
                }
            }
        }

        

        public bool Buscar(int dato)
        {
            var estado = false;
            Puntero = Raiz;
            while (Puntero != null && !estado)
            { 
                if(Puntero.Info == dato)
                {
                    estado = true;
                    break;
                }
                Puntero = Puntero.Sig;
            }

            return estado;
        }

    }
}
