namespace Exercice2
{
    class OrderDetail
    {
        private int qty;
        private string taxStatus;
        private Order order;

        public OrderDetail(int qty, string taxStatus, Order order)
        {
            this.qty = qty;
            this.taxStatus = taxStatus;
            this.order = order;
        }

        public float CalculateSubTotal()
        {
            return 0;
        }

        public float CalculateWeight()
        {
            return 0;
        }
    }
}