using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceInGeometry {
	public class Square : Parallelogram {
		public void SetSides(int s1) {
			SetSides(s1, s1);
		}

		public Square() : base() {

		}
		public Square(int s1) : base(s1, s1) {
			//SetSides(s1);
		}
	}
}
