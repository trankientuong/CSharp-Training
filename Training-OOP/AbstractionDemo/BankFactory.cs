using System;

namespace AbstractionDemo
{
    public class BankFactory
    {
        public static IBank GetBankObject(string bankType)
        {
            IBank BankObject = null!;
            if (bankType == "SBI")
            {
                BankObject = new SBI();
            }
            // else if (bankType == "AXIX")
            // {
            //     BankObject = new AXIX();
            // }
            return BankObject;
        }
    }
}