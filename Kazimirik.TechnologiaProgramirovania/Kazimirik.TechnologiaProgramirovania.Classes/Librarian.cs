using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kazimirik.TechnologiaProgramirovania.Classes
{
    public class Librarian
    {
        public int Proces(int currentTic, int countClient)
        {
            switch (countClient)
            {
                case 1:
                    return (currentTic + 3);
                case 2:
                    return (currentTic + 6);
                case 3:
                    return (currentTic + 9);
                case 4:
                    return (currentTic + 12);
                default:
                    return 0;
            }

        }
        static public bool FreeLibrarian()
        {
            
        }
    }
}
