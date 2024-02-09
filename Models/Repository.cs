namespace PartyInvites.Models;

public static class Reposiotry {
    private static List<GuestResponse> responses = new();
    public static IEnumerable<GuestResponse> Responses => responses;

    public static void AddResopnse(GuestResponse response) {
        Console.WriteLine(response);
        responses.Add(response);
    }
}


