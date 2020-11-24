using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

using Calculator.Model.Interface;

namespace Calculator
{
    public class Calculator : ICalculator
    {
        private IEnumerable<IMoney> currencyDenominations = null;
        private Calculator()
        {
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="totalAmountDue">Amount due, expressed in pounds</param>
        /// <param name="amountGiven">Amount given, expressed in pounds</param>
        /// <returns></returns>
        public IList<IMoney> Calculate(in decimal totalAmountDue, in decimal amountGiven)
        {
            // multiply by 100 to convert to pence
            var remainingChange = amountGiven*100 - totalAmountDue*100;

            var change =  new List<IMoney>();

            foreach (var denomination in currencyDenominations)
            {
                if (remainingChange >= denomination.Value)
                {
                    var denominationQty = (int)Math.Floor( remainingChange / denomination.Value );

                    var money = MoneyFactory.Create(denomination.Denomination, denominationQty);

                    change.Add(money);
                    remainingChange -= money.Value;
                }
            }

            if (remainingChange != 0)
            {
                throw new Exception($@"Unexpected remaining change. {remainingChange}");
            }

            return change;
        }

        /// <summary>
        /// Creates an new instance of the calculator and initialise it ready for use.
        /// </summary>
        /// <returns></returns>
        public static ICalculator Create()
        {
            // could do a singleton, but don't really need to.
            // using a create method so the reflection can be moved out of the constructor.
            var newInstance  = new Calculator();
            newInstance.Init();

            return newInstance;
        }

        private void Init()
        {
            var instances = 
                from t in Assembly.GetExecutingAssembly()
                    .GetTypes()
                where t.GetInterfaces().Contains(typeof(IMoney))
                    && t.IsClass
                    && !t.IsAbstract
                select Activator.CreateInstance(t, 1) as IMoney
                ;

            currencyDenominations = instances.OrderByDescending((x) =>x.Value);
        }
    }
}
