namespace ConsoleApp2;

public class Electro
{
    public static int tarif = 100;
    
    public static int Pay(Room room, int ammount)
    {
        int x = ammount * tarif - room.Pokazaniya.Dequeue();
        room.Pokazaniya.Enqueue(x);
        return x;
    }
}