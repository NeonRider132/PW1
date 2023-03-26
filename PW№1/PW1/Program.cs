class Auto
{
    public static double CalculateTime(double distance, double speed)
    {
        return distance / speed;
    }
    class Automobile
    {
        public string title;
        public double speed;
    }
    public static void anounce(string title, double speed)
    {
        Console.WriteLine("Гонщик " + title);
        Console.WriteLine("Скорость " + speed);
    }
    static void Main(string[] args)
    {
        double distance = 450;
        string title1 = "Baratr";
        double speed1 = 35;
        string title2 = "Seeker";
        double speed2 = 27;
        string title3 = "BHunter";
        double speed3 = 21;
        string title4 = "Spectre";
        double speed4 = 19;
        anounce(title1, speed1);
        anounce(title2, speed2);
        anounce(title3, speed3);
        anounce(title4, speed4);
        Console.WriteLine();
        double time1 = CalculateTime(distance, speed1);
        double time2 = CalculateTime(distance, speed2);
        double time3 = CalculateTime(distance, speed3);
        double time4 = CalculateTime(distance, speed4);
        double time; string title;
        if (time1 < time2) { time = time1; title = title1; }
        else { time = time2; title = title2; }
        if (time > time3) { time = time3; title = title3; }
        if (time > time4) { time = time4; title = title4; }
        Console.WriteLine("Самым быстрым оказался " + title);
        Console.WriteLine("Его время = " + Math.Round(time, 3));
        Console.ReadKey(true);
    }
}
