using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    public class PersonViews : IPersonViews
    {
        public void showInsertClientId()
        {
            Console.WriteLine("Insert client id");
        }

        public void showInsertTrainerId()
        {
            Console.WriteLine("Insert trainer id");
        }

        public void showPairClientWithTrainer()
        {
            Console.WriteLine("Insert client id");
        }

        public void showPairClientWithTrainerSuccess(int id)
        {
            Console.WriteLine($"Found trainer {id}");
        }

        public void showPairClientWithTrainerUnsuccess()
        {
            Console.WriteLine("Did not find trainer");
        }
    }
}
