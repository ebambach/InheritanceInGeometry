using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceInGeometry {
	public class Parallelogram : Quad{

		public void SetSides(int s1, int s2) {
			SetSides(s1, s2, s1, s2);
		}
		public int CalculateArea() {
			var Area = side1 * side2;
			return Area;
		}
		public Parallelogram() : base() {


		}
		//In the earlier build of this exercise, when we left base() as is, we used
		//SetSides(s1, s2); in order to communicate to what the sides were.
		//By adding the parameters to base(), we can skip that step.
		public Parallelogram(int s1, int s2) : base(s1, s2, s1, s1) {
			
		}
	}
}
