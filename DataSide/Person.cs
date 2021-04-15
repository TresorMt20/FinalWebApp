using System;
using System.ComponentModel.DataAnnotations;
namespace DataSide
{
    public class Person
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string address { get; set; }
        public string phoneNume { get; set; }
        public string email { get; set; }
        public string school { get; set; }

        //// lol buddy

    }
}
