using System;
using System.Collections.Generic; //imports thh name space System.Collections.Generic
namespace AppList
{
    class Program
    {
        static void Main(string[] args)
        {
            Product objProduct;
            List<Product> listProduct = new List<Product>();
            string choice;
            string prodId, prodName;
            double prodPrice;
            DateTime manDate, expDate;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Menu");
                Console.WriteLine("****");
                Console.WriteLine("1. Add Product record");
                Console.WriteLine("2. List products");
                Console.WriteLine("Choose your option (1/2)");
                choice = Console.ReadLine();
                switch(choice)
                {
                    case "1":
                         while(true)
                        {
                            Console.Write("Enter the product id:");
                            prodId = Console.ReadLine();
                            Console.Write("Enter Product Name");
                            prodName = Console.ReadLine();
                            Console.Write("Enter price");
                            prodPrice = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Enter manufacturing date:");
                            manDate = Convert.ToDateTime(Console.ReadLine());
                            Console.Write("Enter Expiry date");
                            expDate = Convert.ToDateTime(Console.ReadLine());
                            objProduct = new Product(prodId, prodName, prodPrice, manDate, expDate);
                            listProduct.Add(objProduct);

                            Console.Write("Do you want to add another product(Y/N)?");
                            var answer = Console.ReadLine();
                            if (answer.ToUpper().Equals("Y"))
                                continue;
                            else
                                break;
                            

                        }

                        break;
                    case "2":
                        if (listProduct.Count == 0)
                            Console.WriteLine("Product list is empty");
                        else
                        {
                            String data = String.Format("{0,-20}{1,-20}{2,-20}{3,-20}{4,-20}\n", "Product Id", "Product Name", "Price", "Manufact Date", "Exp Date");
                            Console.WriteLine();
                            Console.WriteLine("*****************Product List**********");
                            foreach(var item in listProduct)
                            {
                                data += String.Format("{0,-20}{1,-20}{2,-20}{3,-20}{4,-20}\n", item.productId, item.name, item.price, item.manDate.ToString("dd/mm/yyyy"), item.expDate.ToString("dd/mm/yyyy"));
                            }

                            Console.WriteLine($"\n{data}");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;

                }

                Console.WriteLine("Do you want to continue(Y/N)?");
                var response = Console.ReadLine();
                if (response.ToUpper().Equals("Y") == true)
                    continue;
                else
                    break;


            }
            
            
          
        }
    }

    class Product
    {
        public string productId, name;
        public double price;
        public DateTime manDate, expDate;
        public Product(string id, string nameofProduct,double productPrice,DateTime manuDate, DateTime expiryDate)
        {
            this.productId = id;
            this.name = nameofProduct;
            this.price = productPrice;
            this.manDate = manuDate;
            this.expDate = expiryDate;
            
        }
    }
   
}
