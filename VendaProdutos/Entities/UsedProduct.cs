using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace VendaProdutos.Entities
{
    class UsedProduct : Product
    {   //ATRIBUTOS DA SUBCLASSE
        public DateTime ManufactureDate { get; set; }

        //CONSTRUTOR INICIAL DA SUBCLASSE
        public UsedProduct()
        {

        }
        //CONSTRUTOR PADRAO DA SUBCLASSE
        public UsedProduct(string name, double price, DateTime manufactureDate)
            : base (name, price)
        {
            ManufactureDate = manufactureDate;
        }
        //METODO PRICETAG DA SUBCLASSE

        public override string PriceTag()
        {
            return Name
                + " (used) $ "
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + " (Manufacture date: "
                + ManufactureDate.ToString("dd/MM/yyyy")
                + ")";

        }





    }

    

}
