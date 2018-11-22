using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRealmDemo.Model
{
    class Person : RealmObject
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
