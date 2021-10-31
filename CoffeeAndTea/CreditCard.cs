using System;
namespace CoffeeAndTea
{
    class CreditCard : PaymentType
    {
        private string _cardNumber;
        private string _expirationDate;
        private string _securityCode;

        private string SecurityCode
        {
            get { return this._securityCode; }
            set { this._securityCode = value; }
        }

        private string ExpirationDate
        {
            get { return this._expirationDate; }
            set { this._expirationDate = value; }        
        }


        public string CardNumber
        {
            get { return this._cardNumber; }
            set { this._cardNumber = value; }
        }

        //No default valud construction since card number would be req if user accept to pay with cards
        public CreditCard(string name, string cardNumber, string expirationDate, string securityCode, decimal payment) : base (name, payment)
        {
            this._cardNumber = cardNumber;
            this._expirationDate = expirationDate;
            this._securityCode = securityCode;
        }

        //It's possible we don't need to return the base value for payment
        public override string ToString()
        {
            //string ccNum = this._cardNumber.Substring(12, 16);
            string result = base.ToString();
            return $"{this.GetType().Name.Substring(0,6)} Card Total Payment: { result }\n";
            // somehow, here we ned to return only the last four digit of the card number when printing the receipt.
        }

    }

}
