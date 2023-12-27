using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Data
{
    public class BankAccount
    {
        private readonly string m_customerName;
        private double m_balance;

        public BankAccount(string customerName, double balance)
        {
            this.m_customerName = customerName;
            m_balance = balance;
        }

        public string GetCustomerName
        {
            get { return m_customerName; }
        }

        public double GetBalance
        {
            get { return m_balance; }
        }

        /// <summary>
        /// Agregar dinero
        /// </summary>
        /// <param name="amount">Monto agregar</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public void Credit(double amount)
        {
            if (amount < 0)
                throw new ArgumentOutOfRangeException("amount");

            this.m_balance += amount;
        }

        /// <summary>
        /// Retirar Dinero
        /// </summary>
        /// <param name="amount">Monto a retirar</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public void Debit(double amount)
        {
            if (amount > this.m_balance)
                throw new ArgumentOutOfRangeException("amount");

            if (amount < 0)
                throw new ArgumentOutOfRangeException("amount");

            //  TODO: Intencionalmente codigo incorrecto
            this.m_balance += amount;
        }
    }
}
