namespace Exercice2
{
    class Customer
    {
        private string name;
        private string deliveryAddress;
        private string contact;
        private bool active;
        private Order[] order;

        public Customer(string name, string deliveryAddress,string contact, bool active)
        {
            this.name = name;
            this.deliveryAddress = deliveryAddress;
            this.contact = contact;
            this.active = active;
            order = new Order[5];

        }
    }
}