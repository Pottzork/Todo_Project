using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using XamarinTodo.Models;

namespace XamarinTodo.Data.Services
{
    public class MockDatabase : JoinStuffThingy
    {
        //public List<Orders> OrderList;
        //public List<Customers> CustomerList;
        //public List<Operators> OperatorList;
        Orders orders = new Orders();
        Operators operators = new Operators();
        Customers customers = new Customers();

        public static IEnumerable<Orders> OrderList()
        {
            return new List<Orders>()
            {
                new Orders{ OrderId = 0, OrderDescription="Fixa elkoppling", OrderAccept=false,
                            OrderStart= DateTime.Now, OrderEnd=DateTime.Now, OrderComplete=false,
                            OrderPrice=0, OrderInfo="Dörr på baksidan", CustomerCusId=1, OperatorID=1},
                
                new Orders{ OrderId = 1, OrderDescription="Trasigt kylskåp", OrderAccept=false,
                            OrderStart= DateTime.Now, OrderEnd=DateTime.Now, OrderComplete=false,
                            OrderPrice=0, OrderInfo="Andra våningen", CustomerCusId=1, OperatorID=1},
                
                new Orders{ OrderId = 2, OrderDescription="Trasig eskalator", OrderAccept=false,
                            OrderStart= DateTime.Now, OrderEnd=DateTime.Now, OrderComplete=false,
                            OrderPrice=0, OrderInfo="", CustomerCusId=1, OperatorID=1},
                
                new Orders{ OrderId = 3, OrderDescription="Trasigt kylskåp", OrderAccept=false,
                            OrderStart= DateTime.Now, OrderEnd=DateTime.Now, OrderComplete=false,
                            OrderPrice=0, OrderInfo="Andra våningen", CustomerCusId=1, OperatorID=1}
            };
        }


        public static IEnumerable<Customers> CustomerList()
        {

             return new List<Customers>()
            {
                new Customers() { Id = 1, Name = "Kalle Johansson", Email = "kalle@hotmail.com",
                    Phone = "0702001001", Company = "Kalle AB",
                    Address = "Kallegatan 1, 111 11, Kallestad" },

                new Customers() { Id = 2, Name = "Ingrid Persson", Email = "ingrid@hotmail.com",
                    Phone = "0702002002", Company = "Ingrid AB",
                    Address = "Ingridgatan 2, 222 22, Ingridsstad" },

                new Customers() { Id = 3, Name = "Nisse Klaesson", Email = "nisse@hotmail.com",
                    Phone = "0702003003", Company = "Nisse AB",
                    Address = "Nissegatan 3, 333 33, Nissestad"   },

                new Customers() { Id = 4, Name = "Madicken Lindgren", Email = "madicken@hotmail.com",
                    Phone = "0702004004", Company = "Madicken AB",
                    Address = "Madickengatan 4, 444 44, Madickenstad"  }
            };
        }
        
        
        public static IEnumerable<Operators> OperatorList()
        {
            return new List<Operators>()
            {
                new Operators { Id = 1, UserName = "SveLju1", Password = "SveLju1",
                    FirstName = "Sven", LastName = "Ljungberg", Email = "svelju@gmail.com",
                    Phone = "0046001001", Location = "Göteborg"},

                new Operators { Id = 2, UserName = "NinHan2", Password = "NinHan2",
                    FirstName = "Nina", LastName = "Hansson", Email = "ninhan@gmail.com",
                    Phone = "0046002002", Location = "Göteborg" },

                new Operators { Id = 3, UserName = "AndPet3", Password = "AndPet3",
                    FirstName = "Anders", LastName = "Pettersson", Email = "andpet@gmail.com",
                    Phone = "0046003003", Location = "Göteborg" },

                new Operators { Id = 4, UserName = "FreTor4", Password = "FreTor4",
                    FirstName = "Freja", LastName = "Torsdottir", Email = "fretor@gmail.com",
                    Phone = "0046004004", Location = "Göteborg" }
            };
        }

        

    }



    public class JoinStuffThingy
    {
        public string thisOrder { get; set; }
        public static string orderThis { get; set; }

        public static void Demo()
        {
            string thisOrder = null;

            JoinDemo(thisOrder);

        }

        public static string JoinDemo(string thisOrder)
        {
            var theOrders = MockDatabase.OrderList();
            //var theOperators = MockDatabase.OperatorList();
            var theCustomers = MockDatabase.CustomerList();


            var join = theCustomers.Join(theOrders, p => p.Id, t => t.OrderId, (p, t) => new
            {
                p.Company,
                p.Address,
                p.Name,
                p.Phone,
                t.OrderId,
                t.OrderDescription,
                t.OrderInfo
            });

            foreach (var no in join)
            {
                string recievedOrder = $"{no.Company}!{no.Address}!" +
                                    $"{no.Name}!{no.Phone}!{no.OrderId}!" +
                                    $"{no.OrderId}!{no.OrderDescription}!" +
                                    $"{no.OrderInfo}";
                thisOrder = recievedOrder.ToString();

            }

            return thisOrder;
        }
        
        

    }




}