namespace OOP.Generics.Arrays
{
    // Not: Classlar referans tipli yapılar, Struct değer tipli yapılardır.

    public struct Company // Değer tipli ifadeler.
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }

        public override string ToString()
        {
            return $"{Id,-5} {Name,-20} {Country,-15}";
            //return base.ToString();
        }
    }
}
