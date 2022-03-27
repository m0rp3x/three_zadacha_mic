namespace ConsoleApp2;

public class Room
{
    public int Members;
    public int VatConsumed;
    private int PayedLast;
    public Queue<int> Pokazaniya = new Queue<int>();
    
    public Room()
    {
        Members = new Random().Next(1, 5);
        
        Pokazaniya.Enqueue(0);
    }

    public void pay()
    {
        VatConsumed += new Random().Next(1, 5);
        PayedLast = Gaz.Pay(this) + Electro.Pay(this, VatConsumed);
        if (PayedLast >= 1000)
        {
            Console.WriteLine($"Рандомная фамилия: {PayedLast}");
        }
    }
}