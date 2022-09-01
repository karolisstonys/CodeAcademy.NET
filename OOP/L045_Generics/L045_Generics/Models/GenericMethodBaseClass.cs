using L045_Generics.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L045_Generics.Models
{
    public class GenericMethodBaseClass
    {
        // Printer, Postmail ir t.t galetu buti naudojami GENERIC metodu situacijoms

        public bool Post<TPost>(TPost post) where TPost : IPost
        {
            if (typeof(TPost) == typeof(DateTime))
                return false;
            return true;
        }

        public void Print<T>(T printableData)
        {

        }



    }
}
