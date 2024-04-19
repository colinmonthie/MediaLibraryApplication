using NAudio.Wave;

public static class ProgramFunctions {
    public static bool Command(string[] input, MediaLibrary mediaLibrary) {
        switch (input[0]) {
            case "help":
                DisplayFunctions.DisplayHelp();
                return true;
            case "print":
            bool isAscending = true;
            try {
                isAscending = bool.Parse(input[3]);
            } catch {
                isAscending = true;
            }

            if (input.Length == 4) {
                if (input[1].Equals("tracks", StringComparison.CurrentCultureIgnoreCase)) {
                    mediaLibrary.PrintSortedMedia("tracks", input[2], isAscending);
                } else if (input[1].Equals("podcasts", StringComparison.CurrentCultureIgnoreCase)) {
                    mediaLibrary.PrintSortedMedia("podcasts", input[2], isAscending);
                } else if (input[1].Equals("audiobooks", StringComparison.CurrentCultureIgnoreCase)) {
                    mediaLibrary.PrintSortedMedia(input[1], input[2], isAscending);
                } else {
                    DisplayFunctions.DisplayError("Invalid media type (tracks, podcasts, audiobooks)");
                }
            } else if (input.Length > 1 && input.Length <= 3) {
                if (input[1].Equals("tracks", StringComparison.CurrentCultureIgnoreCase)) {
                    mediaLibrary.PrintSortedMedia("tracks", "title", isAscending);
                } else if (input[1].Equals("podcasts", StringComparison.CurrentCultureIgnoreCase)) {
                    mediaLibrary.PrintSortedMedia("podcasts", "title", isAscending);
                } else if (input[1].Equals("audiobooks", StringComparison.CurrentCultureIgnoreCase)) {
                    mediaLibrary.PrintSortedMedia("audiobooks", "title", isAscending);
                } else {
                    DisplayFunctions.DisplayError("Invalid mediaType (tracks, podcasts, audiobooks)");
                }
            } else if (input.Length == 1) {
                mediaLibrary.DisplayAllMedia();
            } else {
                DisplayFunctions.DisplayError("Invalid Syntax (print {string} {string} {true/false})");
            }
                return true;
            case "search":
                mediaLibrary.SearchMedia();
                return true;
            case "add":
                mediaLibrary.CreateMedia(input[1]);
                return true;
            case "remove":
                mediaLibrary.RemoveMedia(input[1]);
                return true;
            case "play":
                mediaLibrary.PlayMedia(input[1]);
                return true;
            case "quit":
            Console.WriteLine("Are you sure? (Y/N)");
            if (Console.ReadLine() == "Y") {
                return false;
            } else {
                return true;
            }   
            default:
                DisplayFunctions.DisplayError("Invalid Syntax (try using 'help')");
                return true;
        }
    }

    public static bool UserInput(MediaLibrary mediaLibrary) {
        Console.WriteLine("--------------------------------------------");
        Console.Write(">> ");
        string? input = Console.ReadLine();
        string[] arguments = input.Split(' ');
        DisplayFunctions.ClearConsole();
        return Command(arguments, mediaLibrary);
    }

    public static void PlayMp3File(string filePath) {
        if (!File.Exists(filePath)) {
            DisplayFunctions.DisplayError($"Media '{filePath}.mp3' does not exist.");
            return;
        }

        using (var audioFile = new AudioFileReader(filePath))
        using (var outputDevice = new WaveOutEvent()) {
            outputDevice.Init(audioFile);
            outputDevice.Play();
            Console.WriteLine("Playing... press any key to stop.");
            Console.ReadKey();
            outputDevice.Stop();
        }
    }
}