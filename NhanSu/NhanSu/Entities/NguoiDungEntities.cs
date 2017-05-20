using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhanSu.Entities
{
    class NguoiDungEntities
    {
        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        private string pass;

        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }
    }
}
