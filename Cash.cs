namespace Exercice2
{
    class Cash : Payment
    {
        private float cashTendered;

        public Cash(float cashTendered, Payment payment) : base(payment.amount)
        {
            this.cashTendered = cashTendered;
        }
    }
}