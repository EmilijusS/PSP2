using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSP2
{
    public interface IPersonViews
    {
        void showInsertClientId();
        void showInsertTrainerId();
        void showPairClientWithTrainer();
        void showPairClientWithTrainerSuccess(int id);
        void showPairClientWithTrainerUnsuccess();
    }
}
