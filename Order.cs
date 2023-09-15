namespace Exercice2
{
    class Order
    {
        private DateTime createDate;
        private List<OrderDetail> lod;
        private Payment payment;
        
        public Order(DateTime createDate, List<OrderDetail> lod)
        {
            this.createDate = createDate;
            this.lod = lod;
            payment = new Payment(0);
        }

    }
}