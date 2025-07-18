using System;
public class Program
{
    public static void Main()
    {
        Address address1 = new Address("100 Main St", "New York", "NY", "USA");
        Address address2 = new Address("200 Brickle Ave", "Miami", "FL", "USA");
        Address address3 = new Address("500 Sunset Blvd", "Los Angeles", "CA", "USA");

        Event lecture = new Lecture("Tech Trends 2024", "A lecture on emerging tech trends.", "Nov 5, 2024", "10:00 AM", address1, "Dr. Leo Smith", 100);
        Event reception = new Reception("Networking Mixer", "An evening of networking and socializing.", "Nov 10, 2024", "6:00 PM", address2, "rsvp@eventco.com");
        Event outdoor = new OutdoorGathering("Renaissance Festival", "A celebration of art and culture.", "Nov 15, 2024", "1:00 PM", address3, "Sunny with mild breeze");

        List<Event> events = new List<Event> { lecture, reception, outdoor };

        foreach (Event ev in events)
        {
            Console.WriteLine("----- Standard Details -----");
            Console.WriteLine(ev.GetStandardDetails());
            Console.WriteLine("----- Full Details -----");
            Console.WriteLine(ev.GetFullDetails());
            Console.WriteLine("----- Short Description -----");
            Console.WriteLine(ev.GetShortDescription());
            Console.WriteLine();
        }
    }
}