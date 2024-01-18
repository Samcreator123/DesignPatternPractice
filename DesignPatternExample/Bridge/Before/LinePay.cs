namespace DesignPatternExample.Bridge.Before
{
    public class LinePay
    {
        int _balance;
        public LinePay(int balance)
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
