namespace Exercice2
{
    public class Wireless : Payment
    {
        private string bankID;
        private string bankName;

        public Wireless(string bankID,string bankName, Payment payment) : base(payment.amount)
        {
            this.bankName = bankName;
            this.bankID = bankID;
        }
    }
}