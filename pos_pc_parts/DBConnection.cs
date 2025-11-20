using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pos_pc_parts
{
    internal class DBConnection
    {
        public string GetConnection()
        {
            return "server=localhost;database=pc_parts_pos;uid=root;pwd=A40o8ccjr";
        }
    }
}
