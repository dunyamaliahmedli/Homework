using System;


namespace VehicleCars
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Welcome. Qiymetleri daxil edin: Widht");
			Rectangular duzbucaqli1 = new Rectangular();
			Square kvadrat1 = new Square();
			duzbucaqli1.Width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lenght daxil edin:");
			duzbucaqli1.Lenght = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Kvadratin Side qiymetini daxil edin");
			kvadrat1.side = Convert.ToInt32(Console.ReadLine());


			
			int key = 0;
			do
			{
				
				Console.WriteLine("Welcome.Secim edin:");
				Console.WriteLine("1.Square");
				Console.WriteLine("2.Rectangular");
				Console.WriteLine("3.1.Square");
				key = Convert.ToInt32(Console.ReadLine());

				switch (key)
				{
					case 1:
						if (duzbucaqli1.Lenght > 0)
						{
							if (duzbucaqli1.Width >0)
							{
								Console.WriteLine(kvadrat1.CalcArea());
								
							}
							else
							{
                                Console.WriteLine("Menfi eded ola bilmez ");
								

							}
							}
						else
						{
                            Console.WriteLine("Menfi eded ola bilmez");
						}
							break;

					case 2:
						if (kvadrat1.side > 0)
						{
							Console.WriteLine(duzbucaqli1.CalcArea());
						}
						else 
						{
                            Console.WriteLine("menfi eded ola bilmez");						
						}
						
						break;
					case 3:
						Console.WriteLine("bye bye");
						break;

				}
			} while (key!=3);
			
			
		 //

		}

	}

     abstract class Figure
	{
		public abstract int CalcArea();

		
	}


	class Rectangular : Figure
	{
		public int Lenght { get; set; }
		public int Width { get; set; }

        public Rectangular()
        {
			Lenght = Lenght;
			Width = Width;

				
        }
		public override int CalcArea()
		{
			return Lenght * Width; 
		}
    }

	class Square : Figure
	{
		public int side { get; set; }

        public Square()
        {
			side = side;

        }

        public override int CalcArea()
        {
			return side * side;
        }
    }
}