using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using CalcWCF;
using System.ServiceModel;

namespace WindowsServiceHost
{
    public partial class DonWCFService : ServiceBase
    {
        public DonWCFService()
        {
            InitializeComponent();
        }

        ServiceHost sh = null;
        protected override void OnStart(string[] args)
        {
            sh = new ServiceHost(typeof(CalculatorService), new Uri("net.tcp://localhost:9001/myservice"));
            sh.Open();
        }

        protected override void OnStop()
        {
            if (sh != null)
                sh.Close();
            sh = null;
        }
    }
}
