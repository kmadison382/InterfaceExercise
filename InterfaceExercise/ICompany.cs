using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public interface ICompany
    {
        public string OriginCountry {get; set;}
        public string PriceRange {get; set;}
    }
}