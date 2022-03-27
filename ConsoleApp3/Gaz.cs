namespace ConsoleApp2;

public class Gaz
{
    public static int tarif = 350;

    public static int Pay(Room room)
    {
        return tarif * room.Members;
    }
}