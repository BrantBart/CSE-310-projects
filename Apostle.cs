namespace ApostlesApp
{
    class Apostle
    {
        public string Name { get; set; }
        public int Seniority { get; set; }

        public Apostle(string name, int seniority)
        {
            Name = name;
            Seniority = seniority;
        }
    }
}