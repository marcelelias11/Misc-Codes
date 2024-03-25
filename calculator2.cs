using System;
using System.Text;
using System.Threading.Tasks;

namespace calculator2
{
	class Program
	{
		static void Mean()
		{
			double[] meanlist = {0D};
			double mean;
			Console.Write(" \n\n Numero de dados: ");
			int numero = Convert.ToInt32(Console.ReadLine());
			Console.Write(" \n\n Insira abaixo os dados: ");
			Console.Write("\n\n");
			meanlist = new double[numero];
			for (int i = 0; i < numero; i++)
			{
				double dado = Convert.ToDouble(Console.ReadLine());
				meanlist[i] = dado;
			}
			double sum = 0;
			for (int i = 0; i < meanlist.Length; i++)
			{
				sum += meanlist[i];
			}
			double num = numero;
			mean = sum / num;
			Console.Write(" \n\n Media: " + mean);
			Console.Write("\n\n");
		}
		static void Lab()
		{
			Console.Write(" \n\n Função ainda não implementada");
			Console.Write("\n\n");
		}
		static void MyCode()
		{
			string finalanswer = "y";
			switch (finalanswer)
			{
				case "y":
					do
					{
						Console.Write(" \n\n Qual tarefa executar?");
						Console.Write(" \n\n Escreva sair ou quit para encerrar");
						Console.Write(" \n\n 1) Tirar Media");
						Console.Write(" \n\n 2) Resultado experimento");
						Console.Write("\n\n");
						string answer = Console.ReadLine();
						string answer1 = " ";
						switch (answer)
						{
							case "sair":
								finalanswer = " ";
								break;
							case "quit":
								finalanswer = " ";
								break;
							case "q":
								finalanswer = " ";
								break;
							case "qqq":
								finalanswer = " ";
								break;
							default:
								answer1 = answer;
								switch (answer1)
								{
									case "1":
										Mean();
										break;
									case "2":
										Lab();
										break;
									default:
										Console.Write(" \n\n Entrada inválida");
										break;
								}
								if (answer1 == "1" || answer1 == "2")
								{
								Console.Write(" \n\n Deseja utilizar outra função? y ou n");
								Console.Write("\n\n");
								finalanswer = Console.ReadLine();
								}
								break;
						}
					}
					while(finalanswer == "y" || finalanswer == "Y");
					return;
				case "sair":
					break;
				default:
					Console.Write(" \n\n Entrada inválida");
					return;
			}
		}
		static void Main(string[] args)
		{
			MyCode();
		}
	}
}