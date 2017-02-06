using System.Collections.Generic;
using System.Linq;

namespace LosTechies.DaysOfRefactoring.EncapsulateCollection.Before
{
	public class Order
	{
		private List<OrderLine> _orderLines;
		private double _orderTotal;

		public List<OrderLine> OrderLines
		{
			get { return _orderLines; }
		}

		public void AddOrderLine(OrderLine orderLine)
		{
			_orderTotal += orderLine.Total;
			_orderLines.Add(orderLine);
           
		}
//62 140 bao1 60 xx 100 e5 -7 57 215b 268 263 wt 183 1390
		public void RemoveOrderLine(OrderLine orderLine)
		{
			orderLine = _orderLines.Find(o => o == orderLine);

			if (orderLine == null)
				return;

			_orderTotal -= orderLine.Total;
			_orderLines.Remove(orderLine);
		}
	}

	public class OrderLine
	{
		public double Total { get; private set; }
	}
}
