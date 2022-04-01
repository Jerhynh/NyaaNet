﻿using System;
using System.Reflection;
using NyaaNet;
using NyaaNet.Enums;
using NyaaNet.Enums.SortingParameters;
using NyaaNet.Enums.SubCategories;

namespace NyaaNetTesting
{
    internal class Program
    {
        static async Task Main()
        {
            Console.Title = $"NyaaNet Testing Utility | Version: {Assembly.GetExecutingAssembly().GetName().Version}";
            //APIClient client = new("http://127.0.0.1:8080/","admin", "pass1234");
            //Console.WriteLine(await client.HealthCheckAsync());

            Console.WriteLine("Simply by calling the EnumParsing.ParseEnumValue() method, you can parse a compatible enum value to the corresponding string.");
            Console.WriteLine($"AnimeSubCategories.nonEng is mapped to: {EnumParsing.ParseEnumValue(AnimeSubCategories.nonEng)}");
            Console.WriteLine($"OrderMethods.Ascending is mapped to: {EnumParsing.ParseEnumValue(OrderMethods.Ascending)}");
            Console.ReadLine();
        }
    }
}