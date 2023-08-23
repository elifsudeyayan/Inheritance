// See https://aka.ms/new-console-template for more information

class Kediler
{
    public string turler;
    public int id;

    public void rekedi(string turler, int id)
    {
        Console.WriteLine("Kediler");
        this.turler = turler;
        this.id = id;
        Console.WriteLine(turler + " " + id);
    }
}

class Sokakkedileri : Kediler
{
    public void SokKedi()
    {
        Console.WriteLine("sokakkedigenelnum");
    }
}

class Evkedileri : Kediler
{
    public void EvKedi()
    {
        Console.WriteLine("evkedilerigenelnum");
    }
}

class sokakevkedileri
{
    static void Main(string[] args)
    {
        Kediler tumkediler = new Kediler();
        tumkediler.rekedi("Sokakveevkedilergenelnum", 271215);
        Console.WriteLine("Sokak Kedisi NUM " + tumkediler.turler + " num ID = " + tumkediler.id);

        Sokakkedileri sokakkediler = new Sokakkedileri();
        sokakkediler.SokKedi();

        Evkedileri evkediler = new Evkedileri();
        evkediler.EvKedi();
    }
}