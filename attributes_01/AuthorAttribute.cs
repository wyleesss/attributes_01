namespace AuthorAttribute
{
    [AttributeUsage(AttributeTargets.All)]
    class Author : Attribute
    {
        public string Name { get; }
        public DateOnly LastUpdate { get; }

        public Author(string name, string lastUpdateTime)
        {
            try
            {
                Name = name;
                LastUpdate = DateOnly.FromDateTime(Convert.ToDateTime(lastUpdateTime));
            }
            catch
            {
                Name = string.Empty;
                LastUpdate = DateOnly.MinValue;
            }
        }

        public override string ToString()
        {
            return $"{Name} :: last time updated {LastUpdate}";
        }
    }
}