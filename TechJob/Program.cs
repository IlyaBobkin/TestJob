namespace TechJob
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            Pallet pallet = new Pallet(ID: 10, Width: 20, Height: 10, Weight: 10, Depth: 10);
            Console.WriteLine(pallet.ToString());
        }
    }
}