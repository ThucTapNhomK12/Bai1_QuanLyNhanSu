using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhanSu.Entities
{
    class ChucVuEntities
    {
        private string macv;

        public string Macv
        {
            get { return macv; }
            set { macv = value; }
        }
        private string tencv;

        public string Tencv
        {
            get { return tencv; }
            set { tencv = value; }
        }
        private string phucapcv;

        public string Phucapcv
        {
            get { return phucapcv; }
            set { phucapcv = value; }
        }

        public string Mapb { get; set; }

        public string Tenpb { get; set; }

        public string Sdt { get; set; }

        public string Mahd { get; set; }

        public string Tenhd { get; set; }

        public string ngaykiket { get; set; }

        public string ngayhethan { get; set; }
    }
   }

