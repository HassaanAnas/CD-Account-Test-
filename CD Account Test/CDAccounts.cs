using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CD_Account_Test
{
    class CDAccounts : SavingsAccount
    {
        // Field
        private string _maturityDate;

        // Constructor
        public CDAccounts ()
        {
            _maturityDate = "";
        }

        // MaturityDate property
        public string MaturityDate
        {
            get { return _maturityDate; }
            set { _maturityDate = value; }
        }
    }
}
