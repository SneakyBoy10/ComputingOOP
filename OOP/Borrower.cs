using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Borrower
    {
        public int borrowerID;
        public string fName;
        public string sName;
        public string postcode;
        public int houseNumber;

        public Borrower(int _borrowerID, string _fName, string _sName, string _postcode, int _houseNumber)
        {
            borrowerID = _borrowerID;
            fName = _fName;
            sName = _sName;
            postcode = _postcode;
            houseNumber = _houseNumber;
        }
    }
}
