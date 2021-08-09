using AlunosMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlunosMvc.Repository
{
    public abstract class BaseRepository<T> where T : BaseModel
    {
        private static List<T> List = new List<T>();
        private static int id = 1;
        public void Create(T model)
        {
            model.Id = id;
            id++;
            List.Add(model);
        }
        public List<T> Read()
        {
            return List;
        }
        public T Read(int id)
        {
            return List.Find(s => s.Id == id);
        }
        public void Update(T model)
        {
            int index = List.FindIndex(s => s.Id == model.Id);

            if (index != -1)
            {
                List[index] = model;
            }
        }
        public void Delete(T model)
        {
            int index = List.FindIndex(s => s.Id == model.Id);
            if (index != -1)
            {
                List.Remove(model);
            }
        }
    }
}