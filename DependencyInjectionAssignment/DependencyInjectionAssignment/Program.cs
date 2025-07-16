// See https://aka.ms/new-console-template for more information
using DependencyInjectionAssignment;
using System.Reflection.Metadata.Ecma335;

Console.WriteLine("Write some message please!");

var processor1 = new DataProcessingService();
var userInputProcessor1 = new UserInputProcessor(processor1);

userInputProcessor1.processTheInput();