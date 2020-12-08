using System;
using System.IO;
using System.Collections.Generic;
namespace binaryFiles
{
   class Program
    {
         static string dirPath = @"/Users/tyrichardson/Coding/C#_Beginners-Udemy/binaryFiles/";
         static string filePath = dirPath + "products.dat";
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
                Console.WriteLine("1. Add Product Record");
                Console.WriteLine("2. List Products");
                Console.Write("Choose Your Option(1/2):");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        bool dirStatus = CheckDirectoryExists(dirPath);
                        if (dirStatus == true)
                        {
                            while (true)
                            {
                                Console.Write("Enter Product Id:");
                                prodId = Console.ReadLine();
                                Console.Write("Enter Product Name:");
                                prodName = Console.ReadLine();
                                Console.Write("Enter Product Price:");
                                prodPrice = Convert.ToDouble(Console.ReadLine());
                                Console.Write("Enter Product Manufacturing Date(mm/dd/yy):");
                                manDate = Convert.ToDateTime(Console.ReadLine());
                                Console.Write("Enter Product Expiry Date(mm/dd/yy):");
                                expDate = Convert.ToDateTime(Console.ReadLine());


                                objProduct = new Product(prodId, prodName, prodPrice, manDate, expDate);
                                listProduct.Add(objProduct);

                                Console.Write("Do you want to continue adding another product(Y/N)?:");

                                var answer = Console.ReadLine();
                                if (answer.ToUpper().Equals("Y") == true)
                                    continue;
                                else
                                    break;
                            }
                            WriteData(listProduct);
                            listProduct.Clear();
                        }
                        else
                        {
                            Console.WriteLine("Directory does not exist");
                        }
                        break;
                        case "2":
                           List<Product> prodItems = ReadData();
                           if (prodItems.Count == 0)
                               Console.WriteLine("Product List is Empty");
                           else
                           {
                               String data = String.Format("{0,-20} {1,-20} {2,-20} {3, -20} {4, -20} \n", "Product Id", "Product Name", "Price", "Manufacturing Date", "Expiry Date");
                               Console.WriteLine();
                               Console.WriteLine("*********Product List*******");
                               foreach (var item in prodItems)
                               {
                                   data += String.Format("{0,-20} {1,-20} {2, -20} {3, -20} {4, -20} \n", item.productId, item.name, item.price, item.manDate.ToString("dd/MM/yyyy"), item.expDate.ToString("dd/MM/yyyy"));
                            }
                               Console.WriteLine($"\n{data}");
                           }
                           break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
                Console.Write("Do you want to continue(Y/N)?:");
                var response = Console.ReadLine();

                if (response.ToUpper().Equals("Y") == true)
                    continue;
                else
                    break;
                
            }
        }
       static void WriteData(List<Product> prodList)
        {
            FileStream fs = null;
            BinaryWriter bw = null;
            try
            {
               
                    fs = new FileStream(filePath, FileMode.Append, FileAccess.Write);
                    bw = new BinaryWriter(fs);
                    foreach (Product item in prodList)
                    {
                        bw.Write(item.productId);
                        bw.Write(item.name);
                        bw.Write(item.price);
                        bw.Write(item.manDate.ToString());
                        bw.Write(item.expDate.ToString());
                    }
                
               
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine($"Directory Path {dirPath} Not Found");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"File {filePath} Not Found");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                if (fs != null)
                {
                    bw.Close();
                    fs.Close();
                }
            }
        }
        static List<Product> ReadData()
         {
             FileStream fs = null;
             BinaryReader br = null;
             Product objProduct;
             List<Product> prodList = new List<Product>();
             try
             {
                 if (Directory.Exists(dirPath) && File.Exists(filePath))
                 {
                     fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                     br = new BinaryReader(fs);
                     while (br.PeekChar() != -1)
                     {
                         objProduct = new Product(br.ReadString(),br.ReadString(),br.ReadDouble(),Convert.ToDateTime(br.ReadString()),Convert.ToDateTime(br.ReadString()));
                         prodList.Add(objProduct);
                     }
                 }
                 else
                 {
                     Console.WriteLine("Directory or File does not exist");
                 }
             }
             catch (DirectoryNotFoundException)
             {
                 Console.WriteLine($"Directory Path {dirPath} Not Found");
             }
             catch (FileNotFoundException)
             {
                 Console.WriteLine($"File {filePath} Not Found");
             }
             catch (IOException ex)
             {
                 Console.WriteLine($"Error: {ex.Message}");
             }
             finally
             {
                 if (fs != null)
                 {
                     br.Close();
                     fs.Close();
                 }
             }
         
            return prodList;
         }

        static bool CheckDirectoryExists(string path)
        {
            bool flag;
            if (Directory.Exists(path))
            {
                flag = true;
            }
            else
            {
                flag = false;
            }
            return flag;
        }
    }
        class Product
        {
        public string productId, name;
        public double price;
        public DateTime manDate, expDate;
        public Product(string id, string nameofProduct, double productPrice, DateTime manuDate, DateTime expiryDate)
        {
            this.productId = id;
            this.name = nameofProduct;
            this.price = productPrice;
            this.manDate = manuDate;
            this.expDate = expiryDate;
        }
    }
  }

