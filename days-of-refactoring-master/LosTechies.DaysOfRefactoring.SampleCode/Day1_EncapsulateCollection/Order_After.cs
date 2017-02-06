using System.Collections.Generic;
using System.Linq;

namespace LosTechies.DaysOfRefactoring.EncapsulateCollection.After
{
	public class Order
	{
		private List<OrderLine> _orderLines;
		private double _orderTotal;

		public IEnumerable<OrderLine> OrderLines
		{
			get { return _orderLines; }

		}

		public void AddOrderLine(OrderLine orderLine)
		{
			_orderTotal += orderLine.Total;
			_orderLines.Add(orderLine);
            foreach(var p in OrderLines)
            {

            }
            
		}

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
        Order order = new Order();
        
    }
}