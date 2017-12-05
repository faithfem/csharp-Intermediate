namespace Composition //A kind of rltnshp btw 2 classes that allows one to contain the other. Benefits: code reuse, flexibility, loose-coupling
{
    public class DbMigrator
    {
        private readonly Logger _logger;

        public DbMigrator(Logger logger) //creates association with the logger file/class
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.Log("Migrating file...");
        }
    }
}
