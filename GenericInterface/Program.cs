﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }

    internal interface IEntity
    {
        int Id { get; }
    }

    internal interface IRepository<T> where T : IEntity
    {
        void Add(T entity);
        void Remove(T entity);
    }

    internal class Product : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    internal class ProductRepository : IRepository<Product>
    {
        public void Add(Product entity)
        {

        }

        public void Remove(Product entity)
        {

        }
    }
}
