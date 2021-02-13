using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_support_desk
{
    class Klient
    {
            public string Emri
            {
                get;
                set;
            }
            public int Id
            {
                get;
                set;
            }

            public Klient(string emri, int id)
            {
                Emri = emri;
                Id = id;
            }
    }
}
