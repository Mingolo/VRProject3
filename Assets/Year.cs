using System;

namespace AssemblyCSharp
{
	public class Year
	{
		//always stored in same order: white, black, other
		private double[] raceData;

		//always stored in same order: heterosexual, homosexual, bisexual
		private double[] orientationData;


		public Year (double[] rd, double[] od)
		{
			raceData = rd;
			orientationData = od;
		}

		public Year(){
			raceData = new double[3];
			orientationData = new double[3];
		}

		public double[] getRaceData(){
			return this.raceData;
		}

		public double[] getOrientationData(){
			return this.orientationData;
		}

	}
}

