using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLLV01
{
    public class ListUser
    {
        private static ListUser instance;

        private List<User> listAccountUser;   

        public List<User> ListAccountUser { get { return listAccountUser; } set { listAccountUser = value; } }
        
        public static ListUser Instance
        {
            get
            {
                if (instance == null)
                    instance = new ListUser();
                return instance;
            }
            set => instance = value;
        }

        private ListUser()
        {
            listAccountUser = new List<User>();
            listAccountUser.Add(new User("duc", "123"));
            listAccountUser.Add(new User("viet", "123"));
        }
    }
}
