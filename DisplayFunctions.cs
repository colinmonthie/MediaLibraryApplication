public static class DisplayFunctions {
    public static void ClearConsole() {
        for (int i = 0; i < 30; i++) {
            Console.WriteLine("\n");
        }
    }
    
    public static void DisplayError(string error) {
        Console.WriteLine("*** ERROR! ***");
        Console.WriteLine("[!] Reason: " + error.ToString()) ;
        Console.WriteLine("[!] Try using 'help' to see avaliable commands.");
    }

    public static void DisplayHelp() {
        Console.WriteLine("MEDIA LIBRARY - Help Menu");
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("- help: Prints help menu");
        Console.WriteLine("- print: Prints all media entries");
        Console.WriteLine("- print {mediaType}: Prints specific media entries");
        Console.WriteLine("- print {mediaType, sortingType}: Prints specific sorted media entries");
        Console.WriteLine("- print {mediaType, sortingType, propertyType}: Prints specific sorted media property entries");
        Console.WriteLine("- search {propertyValue}: Search all media entries matching substring");
        Console.WriteLine("- add {mediaType}: Prompts user to add an entry to the media library");
        Console.WriteLine("- remove {mediaType}: Prompts user to remove an entry from the media library");
        Console.WriteLine("- quit: Exits the program");
    }

    public static string DisplayPromptResponse(string question) {
        Console.WriteLine(question);
        Console.WriteLine("--------------------------------------------");
        Console.Write(">> ");
        string response = Console.ReadLine();
        ClearConsole();
        return response;
    }

    public static void CreateTrack(MediaLibrary mediaLibrary) {

    }
}