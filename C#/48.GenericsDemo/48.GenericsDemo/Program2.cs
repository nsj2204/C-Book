using System;
using System.Collections.Generic;

namespace _48.GenericsDemo
{
    class Category
    {
        public int CatrgoryId { get; set; }
        public string CatrgoryName { get; set; }
    }

    class program2
    {
        static void Main(string[] args)
        {
            var categories = new List<Category>()
            {
                new Category() {CatrgoryId= 1, CatrgoryName="좋은 책"},
                new Category() {CatrgoryId= 2, CatrgoryName="좋은 강의"},
                new Category() {CatrgoryId= 3, CatrgoryName="좋은 컴퓨터"}
            };

            foreach(var category in categories)
            {
                Console.WriteLine($"{category.CatrgoryId} - {category.CatrgoryName}");
            }
        }
    }
}
