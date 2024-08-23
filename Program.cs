using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Iphone");

Iphone iphone= new Iphone(numero: "1", modelo:"IphoneTeste", imei:"4" , memoria:150);

iphone.Ligar();

iphone.ReceberLigacao();

iphone.InstalarAplicativo("PokemonGO");

Console.WriteLine("____________________________________________________________________________________");

Console.WriteLine("Smartphone Nokia");

Nokia nokia= new Nokia(numero:"1" , modelo:"NokiaTeste" , imei:"69" , memoria:250);

nokia.Ligar(); 

nokia.ReceberLigacao(); 

nokia.InstalarAplicativo("ClassRoyale");

Console.WriteLine("____________________________________________________________________________________");    




