using MvcAula20.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcAula20.Repository
{
    public class CarroRepository
    {
    public static List<Carro> ListaCarro = new List<Carro>();
        public void Salvar(Carro model)
        {
            Carro antigo = model;
            Carro car = Buscar(antigo.Id);
            if (car == null)
            {
                ListaCarro.Add(model);
            }
            else
            {
                int index = ListaCarro.FindIndex(c => c.Id == car.Id);
                ListaCarro[index] = antigo;
            }
        }
        public List<Carro> Listar() 
        {
            return ListaCarro;
        }
        public void Excluir(int id)
        {
            Carro car = Buscar(id);
            ListaCarro.Remove(car);
        }
        public Carro Editar(int id)
        {
            Carro car = Buscar(id);
            return car;
        }
        public Carro Buscar(int id)
        {
            Carro car = ListaCarro.Find(c => c.Id == id);
            return car;
        }
    }
}