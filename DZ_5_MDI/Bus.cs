using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_5_MDI
{
	[Serializable]
	public class Bus:IComparable
	{
        public int BusNumber { get; set; }
		public string BusType { get; set; }
        public string Destination { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime TimeDeparture { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime ArrivalTime { get; set;}

        public Bus() {}

		public int CompareTo(object obj)
		{
			if (obj is Bus)
			{
				return DepartureDate.CompareTo(((Bus)obj).DepartureDate);
			}
			throw new NotImplementedException();
		}
	}

}
