namespace DesignPatternExample.Bridge.Before
{
    public class ApplePay
    {
        int _balance;
        public ApplePay(int balance)
        {
            _balance = balance;
        }

        public bool ProcessPayment(int cost)
        {
            if (cost > this._balance) return false;

            this._balance -= cost;

            return true;
        }
    }
}
