﻿﻿using System;
using System.IO;

namespace TextEditor{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
            Edit();
        }

        static void Menu(){
            Console.Clear();
            Console.WriteLine("O que você deseja fazer?");
            Console.WriteLine("1 - Abrir arquivo de texto.");
            Console.WriteLine("2 - Criar um novo arquivo.");
            Console.WriteLine("0 - Sair");
            short option = short.Parse(Console.ReadLine());

            switch(option){
                case 0 :System.Environment.Exit(0); break;
                case 1: Open();break;
                case 2:Edit();break;
                default: Menu();break;
            }
        }

        static void Open(){}

        static void Edit(){
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo");
            Console.WriteLine("----------");
            string text = "";
        
        do{
            text += Console.ReadLine();
            text += Environment.NewLine;
        }
        while (Console.ReadKey().Key != ConsoleKey.Escape);
          Save(text);
        }
        static void Save(string text){
            Console.Clear();
            Console.Write("Qual caminho para salvar o arquivo?");
            var path = Console.ReadLine();

            using(var file = new StreamWriter(path)){
            file.Write(text);
            }
            Console.WriteLine($"Arquivo {path} salvo com sucesso.");
            Console.ReadLine();
            Menu();
                 


        }
    }
}