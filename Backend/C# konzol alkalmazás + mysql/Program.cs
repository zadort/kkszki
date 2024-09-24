using Auto.Model;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using MySqlX.XDevAPI.CRUD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using static Org.BouncyCastle.Asn1.Cmp.Challenge;

namespace Auto
{
    internal class Program
    {
        public static Connect conn = new Connect();
        public static List<Car> cars = new List<Car>();

        static void feltolt()
        {
            conn.Connection.Open();
            string sql = "SELECT * FROM `cars`";
            MySqlCommand cmd = new MySqlCommand(sql, conn.Connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            do
            {
                Car car = new Car();
                reader.Read();
                car.Id = reader.GetInt32(0);
                car.Brand = reader.GetString(1);
                car.Type = reader.GetString(2);
                car.License = reader.GetString(3);
                car.Date = reader.GetInt32(4);
                cars.Add(car);
            } while (reader.Read());
            conn.Connection.Close();
        }

        #region 2. feladat
        //2. feladat
        public static void addNewCar()
        {
            conn.Connection.Open();
            string brand, type, license;
            int date;
            Console.WriteLine("Kérem az autó márkját: ");
            brand = Console.ReadLine();
            Console.Write("Kérem az autó típusát: ");
            type = Console.ReadLine();
            Console.WriteLine("Kérem az autó motorszámát:  ");
            license = Console.ReadLine();
            Console.WriteLine("Kérem az autó gyártási évét: ");
            date = int.Parse(Console.ReadLine());
            string sql = $"INSERT INTO `cars`(`Id`, `Brand`, `Type`, `License`, `Date`) VALUES('{brand}', '{type}', '{license}', '{date}')";
            MySqlCommand cmd = new MySqlCommand();
            cmd.ExecuteNonQuery();
            conn.Connection.Close();
        }
        #endregion

        static void Main(string[] args)
        {
            feltolt();
            foreach (var item in cars)
            {
                Console.WriteLine($"Autó gyártója: {item.Brand}, motorszáma: {item.License}");
            }
            addNewCar();

            Console.ReadLine();
        }
    }
}