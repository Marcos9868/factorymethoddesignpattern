using Product;

namespace ContentProduct
{
    public class PlatinumCard : CreditCard
    {
        private readonly string _cardType;
        private int _creditLimit;
        private int _aditionalPayment;

        public PlatinumCard(int creditLimit, int aditionalPayment)
        {
            _cardType = "Platinum";
            _creditLimit = creditLimit;
            _aditionalPayment = aditionalPayment;
        }

        public override string CardType 
        { 
            get { return _cardType; } 
        }
        public override int CreditLimit 
        { 
            get { return _creditLimit; } 
            set { _creditLimit = value; } 
        }
        public override int AditionalPayment 
        { 
            get { return _aditionalPayment; } 
            set { _aditionalPayment = value; } 
        }
    }
}