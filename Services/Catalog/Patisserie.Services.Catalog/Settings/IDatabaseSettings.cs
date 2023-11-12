namespace Patisserie.Services.Catalog.Settings
{
    public interface IDatabaseSettings
    {
        //options pattern
        public string ProductCollectionName { get; set; }

        public string CategoryCollectionName { get; set; }

        public string ConnectionString { get; set; }

        public string DatabaseName { get; set; }



    }
}
