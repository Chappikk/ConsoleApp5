using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace ConsoleApp1
{
    class one
    {
        public int id { get; set; }
        public string Name { get; set; }
    }
    public struct one1
    {
        public int n_id;
        public string country;
    }
    class two
    {
        public string tip { get; set; }
        public int index { get; set; }
        public string name_h { get; set; }
        public int Price { get; set; }
    }
    public struct two2
    {
        public string polozh;
        public int indexx;
        public string NAME;
        public int price;
    }
   
    
    class Program
    {
        static void Main(string[] args)
        {

           

            try
            {

                int a;
                int d;
                StreamReader sr = new StreamReader("one.txt");

                StreamReader sr1 = new StreamReader("two.txt");
                string line;

                string line1;
                one1 a1;

                two2 a2;
                List<one> users = new List<one>();
                List<two> user = new List<two>();
                Console.WriteLine("Выберите что сделать\n1-По-возрастанию\n2-По-убыванию\n3-Удаление");
                a = Convert.ToInt32(Console.ReadLine());

                if (a == 1)
                {
                    while ((line = sr.ReadLine()) != null && (line1 = sr1.ReadLine()) != null)
                    {
                        string[] temp = line.Split(' ');
                        a1.n_id = Convert.ToInt32(temp[0]);
                        a1.country = temp[1];




                        users.Add(new one { id = a1.n_id, Name = a1.country });

                        string[] temp1 = line1.Split(' ');
                        a2.polozh = temp1[0];
                        a2.indexx = Convert.ToInt32(temp1[1]);
                        a2.NAME = temp1[2];
                        a2.price = Convert.ToInt32(temp1[3]);




                        user.Add(new two { tip = a2.polozh, index = a2.indexx, name_h = a2.NAME, Price = a2.price });
                       
                    }

                    var result = from pl in user
                                 join t in users on pl.index equals t.id

                                 orderby pl.Price

                                 select new { id = t.id, Country = t.Name, Tip = pl.tip, Kol = pl.index, Otel = pl.name_h, Cena = pl.Price };




                    foreach (var item in result)
                        Console.WriteLine($"{item.id} - {item.Country} - {item.Tip}   - {item.Otel} - {item.Cena} ");
                    sr.Close();
                    sr1.Close();
                }

                if(a == 2)
                {
                    while ((line = sr.ReadLine()) != null && (line1 = sr1.ReadLine()) != null)
                    {
                        string[] temp = line.Split(' ');
                        a1.n_id = Convert.ToInt32(temp[0]);
                        a1.country = temp[1];




                        users.Add(new one { id = a1.n_id, Name = a1.country });

                        string[] temp1 = line1.Split(' ');
                        a2.polozh = temp1[0];
                        a2.indexx = Convert.ToInt32(temp1[1]);
                        a2.NAME = temp1[2];
                        a2.price = Convert.ToInt32(temp1[3]);




                        user.Add(new two { tip = a2.polozh, index = a2.indexx, name_h = a2.NAME, Price = a2.price });
                     
                    }
                    var result = from pl in user
                                 join t in users on pl.index equals t.id

                                 orderby pl.Price descending

                                 select new { id = t.id, Country = t.Name, Tip = pl.tip, Kol = pl.index, Otel = pl.name_h, Cena = pl.Price };




                    foreach (var item in result)
                        Console.WriteLine($"{item.id} - {item.Country} - {item.Tip}  -  {item.Otel} - {item.Cena} ");
                    sr.Close();
                    sr1.Close();
                }

                if (a == 3)
                {
                    Console.WriteLine("Ведите индекс элемента для удаления");
                    d=Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    while ((line = sr.ReadLine()) != null && (line1 = sr1.ReadLine()) != null)
                    {
                        string[] temp = line.Split(' ');
                        a1.n_id = Convert.ToInt32(temp[0]);
                        a1.country = temp[1];




                        users.Add(new one { id = a1.n_id, Name = a1.country });

                        string[] temp1 = line1.Split(' ');
                        a2.polozh = temp1[0];
                        a2.indexx = Convert.ToInt32(temp1[1]);
                        a2.NAME = temp1[2];
                        a2.price = Convert.ToInt32(temp1[3]);




                        user.Add(new two { tip = a2.polozh, index = a2.indexx, name_h = a2.NAME, Price = a2.price });
                        

                    }
                    if(d==1 || d == 2)
                    {
                        users.RemoveAt(d-1);
                        var result = from pl in user
                                     join t in users on pl.index equals t.id


                                     select new { id = t.id, Country = t.Name, Tip = pl.tip, Kol = pl.index, Otel = pl.name_h, Cena = pl.Price };

                        foreach (var item in result)
                            Console.WriteLine($"{item.id} - {item.Country} - {item.Tip}  -  {item.Otel} - {item.Cena} ");
                        sr.Close();
                        sr1.Close();
                    }

                    if (d == 3 || d == 4 || d == 5 || d == 6)
                    {
                        user.RemoveAt(d - 1);
                        var result = from pl in user
                                     join t in users on pl.index equals t.id


                                     select new { id = t.id, Country = t.Name, Tip = pl.tip, Kol = pl.index, Otel = pl.name_h, Cena = pl.Price };

                        foreach (var item in result)
                            Console.WriteLine($"{item.id} - {item.Country} - {item.Tip}  -  {item.Otel} - {item.Cena} ");
                        sr.Close();
                        sr1.Close();
                    }
                    if (d > 6)
                    {
                        Console.WriteLine("ERROR");
                    }





                }

                if (a > 3)
                {
                    Console.WriteLine("ERROR");
                }
                
            }
            catch
            {
                Console.WriteLine("ERROR");
            }
                
           
            
           

           
            

            
            
            
           
            



            
            



           

              



        }
    }
}