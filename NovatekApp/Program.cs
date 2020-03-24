using NovatekApp.Controllers;

namespace NovatekApp
{
    class Program
    {
        static void Main(string[] args)
        {
            RootController app = new RootController();
            app.run();
        }
    }
}
