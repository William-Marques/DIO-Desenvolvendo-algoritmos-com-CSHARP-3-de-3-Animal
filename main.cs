using System;
using System.Text;

class MainClass {
  public static void Main (string[] args) {
        String  palavra1; //declare as suas variaveis
        String  palavra2;
        String  palavra3;

        palavra1 = Console.ReadLine(); //insira suas variaveis
        palavra2 = Console.ReadLine();
        palavra3 = Console.ReadLine();



    if ((palavra1 == "vertebrado" ) && (palavra2 == "ave" )  && (palavra3 == "carnivoro" ))
    {
      Console.WriteLine("aguia\n");
    } 
    else if ((palavra1 == "vertebrado" ) && (palavra2 == "ave" )  && (palavra3 == "onivoro")) 
        {
            Console.WriteLine("pomba\n");
        }

    else if ((palavra1 == "vertebrado" ) && (palavra2 == "mamifero" )  && (palavra3 == "onivoro" )) 
    {
      Console.WriteLine("homem\n");
    } 

    else  if ((palavra1 == "vertebrado" ) && (palavra2 == "mamifero" )  && (palavra3 == "herbivoro")) 
        {
            Console.WriteLine("vaca\n");
        }

    else if ((palavra1 == "invertebrado" ) && (palavra2 == "inseto")  && (palavra3 == "hematofago" )) 
    {
      Console.WriteLine("pulga\n");
    } 
    else if ((palavra1 == "invertebrado" ) && (palavra2 == "inseto")  && (palavra3 == "herbivoro"))
        {
            Console.WriteLine("lagarta\n");
        }

    else if ((palavra1 == "invertebrado") && (palavra2 == "anelideo") && (palavra3 == "hematofago")) 
    {
      Console.WriteLine("sanguessuga\n");
    } 
    else if ((palavra1 == "invertebrado") && (palavra2 == "anelideo") && (palavra3 == "onivoro"))
        {
            Console.WriteLine("minhoca\n");
        }


  }
}