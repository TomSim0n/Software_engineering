namespace Exercice2
{
    class Credit : Payment
    {
        private string number;
        private string type;
        private DateTime date;

        public Credit(string number,string type, DateTime date,Payment payment) : base (payment.amount)
        {
            this.number = number;
            this.type = type;
            this.date = date;
        }
    }
}