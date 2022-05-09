using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interfaces.IFormattables
{
    class Employee : IFormattable // IFormattable C#'ın kendi hazırlamış olduğu bir Interface'dir.
    {
        // Employee Properties
        public int Id { get; set; }
        public string Title { get; set; }   
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{Title} {FirstName} {LastName}"; // tek satırlık "get" bloğu




        public override string ToString()
        {
            return this.ToString("F", CultureInfo.CurrentCulture); // CultureInfo --> İşletim sisteminizdeki kültürel bilgiyi alır. Örn: Türkçe, Türk Lirası, Türkiye Saati vs.
            //return base.ToString();
        }

        public string ToString(string format)
        {
            return this.ToString(format, CultureInfo.CurrentCulture); // Aşağıdaki IFormattable ile gelen fonksiyona yönlendiriyor.
        }

        public string ToString(string format, IFormatProvider formatProvider) // IFormattable ile Implement edilmiş method
        {
            //throw new NotImplementedException();

            if (String.IsNullOrEmpty(format)) // format --> Eğer boşsa (IsNullOrEmpty)
                format = "F";
            

            if (formatProvider==null) // formatProvider --> Eğer boşsa
                formatProvider = CultureInfo.CurrentCulture;

            switch (format.ToUpper())
            {
                case "F":
                    return $"{Id} {Title} {FirstName} {LastName}";

                case "FL":
                    return $"{FirstName} {LastName}";

                case "LF":
                    return $"{LastName} {FirstName}";

                case "S":
                    return $"{LastName} {FirstName[0]}";

                default:
                    throw new FormatException(String.Format("The {0} is not supported", format));

            }
        }
    }
}
