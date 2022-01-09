using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace VendaProdutos.Entities
{
    class Product
    {       //atributos da SuperClasse
        public string Name { get; set; }
        public double Price { get; set; }

        //CONSTRUTORES BASICO DA SUPERCLASSE
        public Product()
        {

        }
        //CONSTRUTOR GERAL DA SUPERCLASSE
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        //METODOS DA SUPERCLASSE

       public virtual string PriceTag()
        {
            return Name
                + "  $ "
                + Price.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
