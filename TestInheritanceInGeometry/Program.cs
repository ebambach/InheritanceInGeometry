using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InheritanceInGeometry;

namespace TestInheritanceInGeometry {
	class Program {
		static void Main(string[] args) {
			new Program().Run();
		}
		void Run() {
			Quad quad1 = new Quad(3, 4, 5, 6);
			var Perimeter = quad1.CalculatePerimeter();
			Console.WriteLine($"The perimeter of the quadrilateral is {Perimeter}.");
			Console.WriteLine("");

			Parallelogram para1 = new Parallelogram(7,3);
			Perimeter = para1.CalculatePerimeter();
			Console.WriteLine($"The perimeter of the parallelogram is {Perimeter}.");
			var Area = para1.CalculateArea();
			Console.WriteLine($"The area is {Area}.");
			Console.WriteLine("");

			Square sq1 = new Square(6);
			Perimeter = sq1.CalculatePerimeter();
			Console.WriteLine($"The perimeter of the square is {Perimeter}.");
			Area = sq1.CalculateArea();
			Console.WriteLine($"The area is {Area}.");
			Console.WriteLine("");


		}
	}
}
