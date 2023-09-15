namespace Exercice2
{
     class Check : Payment
    {
        private string name;
        private string bankID;
        private bool authorized;

        public Check(string name, string bankID, Payment payment) : base (payment.amount)
        {
            this.name = name;
            this.bankID = bankID;
            this.authorized = authorize();
        }

        public bool authorize()
        {
            if(name=="arnaque")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}