namespace Exercice2
{
    class Item
    {
        private float weight;
        private string description;
        private OrderDetail[] ordersdetail;

        public Item(float weight, string description)
        {
            this.weight = weight;
            this.description = description;
            this.ordersdetail = new OrderDetail[5];
        }

        public int getPriceForQuantity()
        {
            return 0;
        }
        public int getWeight()
        {
            return 0;
        }
    }
}