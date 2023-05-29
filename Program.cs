using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace OOP_Assignment12
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\USER\Downloads\JSON\myTeam.json";
            List<members> myteam = new List<members>();
            using (StreamReader streamReader = new StreamReader(path))
            {
                var jsonString = streamReader.ReadToEnd();
                myteam = JsonConvert.DeserializeObject<List<members>>(jsonString);
            }
            foreach (var item in myteam)
            {
                Console.WriteLine(
                    "Name:{0},Date Of Birth:{1},Email:{2},Mobile:{3}", 
                    item.Name, item.DateOfBirth, item.ContactInformation[0].Email, item.ContactInformation[0].Mobile);
            }

        }
    }
}
