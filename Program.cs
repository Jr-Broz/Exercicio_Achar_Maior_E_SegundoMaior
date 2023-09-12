using System;
using System.Linq;
using System.Reflection.Metadata;
namespace teste{

    public class Program{
        
        public static void Main(string[] args){


        int[] listagemNumeros = new int[] {1,60,105,40,2950};

        int maior = int.MinValue;
        int segundoMaior = int.MinValue;


        foreach(int i in listagemNumeros){

            if(i > maior){

             segundoMaior = maior;
             maior = i;

            }
            else if(i > segundoMaior){

                segundoMaior = i;
            }
        }

        System.Console.WriteLine(maior);
        System.Console.WriteLine(segundoMaior);














        }
    }
}