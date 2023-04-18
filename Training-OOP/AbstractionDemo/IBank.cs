using System;

namespace AbstractionDemo
{
    // Example to Implement Abstraction Principle in C# using Interface:
    public interface IBank
    {
        void ValidateCard();
        void WithdrawMoney();
        void CheckBalanace();
        void BankTransfer();
        void MiniStatement();
    }


    // Example to Implement Abstraction Principle in C# using Abstract Class and Abstract Methods:
    public abstract class AbstractBankCls{
        public abstract void ValidateCard();
        public abstract void WithdrawMoney();
        public abstract void CheckBalanace();
        public abstract void BankTransfer();
        public abstract void MiniStatement();
    }
}