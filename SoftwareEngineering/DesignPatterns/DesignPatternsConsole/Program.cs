﻿using System;

namespace DesignPatternsConsole
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //var journal = new DesignPatterns.SOLID.Journal();
            //journal.AddEntry("I wrote code today");
            //journal.AddEntry("I drank coffee today");
            //Console.WriteLine(journal);

            //var runner = new DesignPatterns.SOLID.ORunner();
            //runner.Run();
            //var runner = new DesignPatterns.SOLID.DRunner();
            //DesignPatterns.SOLID.DRunner.Run();
            //DesignPatterns.Builder.Builder builder = new DesignPatterns.Builder.Builder();
            //builder.Run();

            //DesignPatterns.Builder.Fluent.FluentBuilder fluent = new DesignPatterns.Builder.Fluent.FluentBuilder();
            //fluent.Run();

            //DesignPatterns.Builder.Faceted.FacetedBuilder faceted = new DesignPatterns.Builder.Faceted.FacetedBuilder();
            //faceted.Run();
            //DesignPatterns.Factories.AbstractFactory abstractFactory = new DesignPatterns.Factories.AbstractFactory();
            //abstractFactory.Run();

            //DesignPatternsVB.Prototype prototype = new DesignPatternsVB.Prototype();
            //prototype.Run();

            //DesignPatterns.Adapter.AdapterPattern adapterPattern = new DesignPatterns.Adapter.AdapterPattern();
            //adapterPattern.Run();
            DesignPatterns.Adapter.AdapterPattern.Run();
            Console.ReadLine();
        }
    }
}
