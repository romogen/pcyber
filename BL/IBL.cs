using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public interface IBL
    {
        long VerifyCredentials(string UserName, string Password);
        bool ChangeUserPassword(string ID, string Password);

        
    }
}
