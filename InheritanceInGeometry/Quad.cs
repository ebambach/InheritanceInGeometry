using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceInGeometry
{
    public class Quad
    {
		protected int side1;
		protected int side2;
		protected int side3;
		protected int side4;

		public void SetSides (int s1, int s2, int s3, int s4) {
			side1 = s1;
			side2 = s2;
			side3 = s3;
			side4 = s4;
		}

		public int CalculatePerimeter() {
			var Sum = side1 + side2 + side3 + side4;
			return Sum;
		}

		public Quad() {

		}
		public Quad(int s1, int s2, int s3, int s4) {
			SetSides(s1, s2, s3, s4);
		}
	}
}
