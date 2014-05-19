using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
namespace NExp.Model.Identity
{
    public class User:IUser
    {
        public virtual string Id
        {
            get;
            set;
        }

        public virtual string UserName
        {
            get;
            set;
        }
    }
}
