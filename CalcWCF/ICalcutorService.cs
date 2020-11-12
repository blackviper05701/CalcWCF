using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CalcWCF
{
    [ServiceContract]
    public interface ICalcutorService
    {
        [OperationContract]
        double Add(int[] numbers);
        [OperationContract]
        double Multifly(int[] numbers);
    }
}
