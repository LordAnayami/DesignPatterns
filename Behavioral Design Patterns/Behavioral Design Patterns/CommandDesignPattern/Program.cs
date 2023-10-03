﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an Instance of Receiver
            Document document = new Document();

            //Create the Command Object by passing the Receiver Instance
            ICommand openCommand = new OpenCommand(document);
            ICommand saveCommand = new SaveCommand(document);
            ICommand closeCommand = new CloseCommand(document);

            //Create the Invoker instance by passing the command objects
            MenuOptions menu = new MenuOptions(openCommand, saveCommand, closeCommand);

            //Giving command to the Invoker to do the operation
            menu.ClickOpen();
            menu.ClickSave();
            menu.ClickClose();

            Console.ReadKey();
        }
    }
}
