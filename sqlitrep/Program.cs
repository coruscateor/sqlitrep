using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLiteConnector;
using dbrep;

namespace sqlitrep
{

    class Program
    {

        static void Main(string[] args)
        {

            new CMDMain<SQLiteDiscreteExecutor>().Run(args);

        }

    }

}
