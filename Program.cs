class Program
{
    static void Main()
    {
        Satelite mySat = new Satelite();
        bool gameActive = true;

        while (gameActive)
        {
            if (mySat.GetBattery() <= 0)
            {
                Console.WriteLine("\n⚠️ [CRITICAL] Battery empty. Mission failed.");
                break;
            }

            Console.WriteLine("\n=====================================");
            Console.WriteLine($"🔋 BATT: {mySat.GetBattery()}% | 🛰️ ALT: {mySat.GetAltitude()}km | 📦 DATA: {mySat.GetScienceData()}MB");
            Console.WriteLine("=====================================");
            Console.Write("Command (SCAN, TRANSMIT, RAISE, LOWER, RECHARGE, EXIT): ");

            string command = Console.ReadLine()?.ToUpper().Trim() ?? string.Empty;

            switch (command) // To do the action of the command that the player choose
            {
                case "SCAN":
                    mySat.Scan(10);
                    break;
                case "TRANSMIT":
                    mySat.Transmit();
                    break;
                case "RAISE":
                    mySat.RaiseAltitude();
                    break;
                case "LOWER":
                    mySat.LowerAltitude();
                    break;
                case "RECHARGE":
                    mySat.Recharge();
                    break;
                case "EXIT":
                    gameActive = false;
                    break;
                default:
                    Console.WriteLine("Unknown command.");
                    break;
            }
        }
    }
}
