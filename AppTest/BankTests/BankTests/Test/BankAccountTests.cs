using Bank;
using Bank.Data;

namespace BankTests.Test
{
    [TestClass]
    public class BankAccountTests
    {
        [TestMethod]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            //  TODO: Definir variables
            double begginningBalance = 11.99;
            double debitAmout = 4.55;
            double expctedBalance = 7.44;
            BankAccount bankAccount = new BankAccount("Ivanna", begginningBalance);

            //  TODO: Debitar
            bankAccount.Debit(debitAmout);

            //  TODO: Assert
            double actualBalance = bankAccount.GetBalance;
            Assert.AreEqual(expctedBalance, actualBalance, 0.001, "A la cuenta no se le debito correctamente");
        }

        [TestMethod]
        public void Debit_WithInvalidAmount_BigThatAmount()
        {
            //  TODO: Definir variables
            double begginningBalance = 11.99;
            double debitAmount = 12;
            BankAccount bankAccount = new BankAccount("Ivanna", begginningBalance);

            //  TODO: Debitar
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => bankAccount.Debit(debitAmount));
        }

        [TestMethod]
        public void Debit_WithInvalidAmount_LessThatZero()
        {
            //  TODO: Definir variables
            double begginningBalance = 11.99;
            double debitAmount = -1;
            BankAccount bankAccount = new BankAccount("Ivanna", begginningBalance);

            //  TODO: Debitar
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => bankAccount.Debit(debitAmount));
        }
    }
}