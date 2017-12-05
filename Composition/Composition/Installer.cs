namespace Composition //A kind of rltnshp btw 2 classes that allows one to contain the other. Benefits: code reuse, flexibility, loose-coupling
{
    public class Installer
    {
        private readonly Logger _logger;

        public Installer(Logger logger)
        {
            _logger = logger;
        }

        public void Install()
        {
            _logger.Log("Installing app.");
        }

        public Logger Logger => _logger;
    }
}
