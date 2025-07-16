using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionAssignment
{
    internal class DepInjectionAssignment
    {


    }

    class UserInputProcessor
    {
        private IDataProcessor _processor;

        public UserInputProcessor(IDataProcessor processor)
        {
            _processor = processor;
        }

        public void processTheInput()
        {

            _processor.processData(Console.ReadLine());
        }

    }

    interface IDataProcessor
    {
        void processData(string data)
        {

        }
    }

    class DataProcessingService :IDataProcessor
    {
        public void processData(string data)
        {
         
            Console.WriteLine(data.ToUpper());
        }

    }
}
