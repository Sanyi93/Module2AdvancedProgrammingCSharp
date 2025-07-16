using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingAssignment

{    
    interface IDataProcessor
    {
        string ProcessData(string input);
       
    }

    public class UserInputProcessor : IDataProcessor
    {
        public string ProcessData(string input)
        {
            return input.ToUpper();
        }
    }
}
