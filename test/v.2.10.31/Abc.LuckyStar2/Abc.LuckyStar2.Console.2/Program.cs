﻿using Microsoft.Crm.Sdk.Messages;
using System;

namespace Abc.LuckyStar2.Console._2
{
    public class Program
    {
        [STAThread]
        static void Main()
        {
            var UserId = ((WhoAmIResponse)AppSettings.Service.Execute(new WhoAmIRequest())).UserId;
            System.Console.WriteLine(UserId);
            System.Console.ReadKey();
        }
    }
}
