using System.Text.Json;

public class MediaLibrary {
    #region Fields
    private List<Track> tracks;
    private List<Podcast> podcasts;
    private List<AudioBook> audioBooks;
    #endregion

    #region Constructors
    public MediaLibrary(List<Track> tracks, List<Podcast> podcasts, List<AudioBook> audioBooks) {
        Tracks = tracks;
        Podcasts = podcasts;
        AudioBooks = audioBooks;
    }
    #endregion

    #region Methods
    public static MediaLibrary LoadLibrary() {
        var options = new JsonSerializerOptions {
            PropertyNameCaseInsensitive = true,
        };
        List<Track> tracks = JsonSerializer.Deserialize<List<Track>>(File.ReadAllText(@"./database/tracks.json"), options);
        List<Podcast> podcasts = JsonSerializer.Deserialize<List<Podcast>>(File.ReadAllText(@"./database/podcasts.json"), options);
        List<AudioBook> audioBooks = JsonSerializer.Deserialize<List<AudioBook>>(File.ReadAllText(@"./database/audiobooks.json"), options);

        MediaLibrary mediaLibrary = new(tracks, podcasts, audioBooks);
        return mediaLibrary;
    }

    public void DisplayAllMedia() {
        PrintSortedMedia("tracks", "title", true);
        Console.WriteLine("\n");
        PrintSortedMedia("podcasts", "title", true);
        Console.WriteLine("\n");
        PrintSortedMedia("audiobooks", "title", true);
    }

    public void PrintSortedMedia(string mediaType, string propertyType, bool isAscending) {
        if (mediaType == "tracks") {
            Console.WriteLine("\tTRACKS [Title, Artist, Album, Year, Duration, Rating]");
            if (isAscending) {
                switch (propertyType) {
                    case "title":
                    tracks.Sort((t1, t2) => t1.Title.CompareTo(t2.Title));
                    break;
                    case "artist":
                    tracks.Sort((t1, t2) => t1.Artist.CompareTo(t2.Artist));
                    break;
                    case "album":
                    tracks.Sort((t1, t2) => t1.Album.CompareTo(t2.Album));
                    break;
                    case "year":
                    tracks.Sort((t1, t2) => t1.Year.CompareTo(t2.Year));
                    break;
                    case "duration":
                    tracks.Sort((t1, t2) => t1.Duration.CompareTo(t2.Duration));
                    break;
                    case "rating":
                    tracks.Sort((t1, t2) => t1.Rating.CompareTo(t2.Rating));
                    break;
                }
            } else {
                switch (propertyType) {
                    case "title":
                    tracks.Sort((t1, t2) => t2.Title.CompareTo(t1.Title));
                    break;
                    case "artist":
                    tracks.Sort((t1, t2) => t2.Artist.CompareTo(t1.Artist));
                    break;
                    case "album":
                    tracks.Sort((t1, t2) => t2.Album.CompareTo(t1.Album));
                    break;
                    case "year":
                    tracks.Sort((t1, t2) => t2.Year.CompareTo(t1.Year));
                    break;
                    case "duration":
                    tracks.Sort((t1, t2) => t2.Duration.CompareTo(t1.Duration));
                    break;
                    case "rating":
                    tracks.Sort((t1, t2) => t2.Rating.CompareTo(t1.Rating));
                    break;
                }
            }
            tracks.ForEach(Console.WriteLine);
        } else if (mediaType == "podcasts") {
            Console.WriteLine("\tPODCASTS [Title, Creator, Year, Duration, Rating]");
            if (isAscending) {
                switch (propertyType) {
                    case "title":
                    podcasts.Sort((p1, p2) => p1.Title.CompareTo(p2.Title));
                    break;
                    case "creator":
                    podcasts.Sort((p1, p2) => p1.Creator.CompareTo(p2.Creator));
                    break;
                    case "year":
                    podcasts.Sort((p1, p2) => p1.Year.CompareTo(p2.Year));
                    break;
                    case "duration":
                    podcasts.Sort((p1, p2) => p1.Duration.CompareTo(p2.Duration));
                    break;
                    case "rating":
                    podcasts.Sort((p1, p2) => p1.Rating.CompareTo(p2.Rating));
                    break;
                }
            } else {
                switch (propertyType) {
                    case "title":
                    podcasts.Sort((p1, p2) => p2.Title.CompareTo(p1.Title));
                    break;
                    case "creator":
                    podcasts.Sort((p1, p2) => p2.Creator.CompareTo(p1.Creator));
                    break;
                    case "year":
                    podcasts.Sort((p1, p2) => p2.Year.CompareTo(p1.Year));
                    break;
                    case "duration":
                    podcasts.Sort((p1, p2) => p2.Duration.CompareTo(p1.Duration));
                    break;
                    case "rating":
                    podcasts.Sort((p1, p2) => p2.Rating.CompareTo(p1.Rating));
                    break;
                }
            }
            podcasts.ForEach(Console.WriteLine);
        } else if (mediaType == "audiobooks") {
            Console.WriteLine("\tAUDIOBOOKS [Title, Artist, Year, Duration, Rating]");
            if (isAscending) {
                switch (propertyType) {
                    case "title":
                    audioBooks.Sort((a1, a2) => a1.Title.CompareTo(a2.Title));
                    break;
                    case "artist":
                    audioBooks.Sort((a1, a2) => a1.Artist.CompareTo(a2.Artist));
                    break;
                    case "year":
                    audioBooks.Sort((a1, a2) => a1.Year.CompareTo(a2.Year));
                    break;
                    case "duration":
                    audioBooks.Sort((a1, a2) => a1.Duration.CompareTo(a2.Duration));
                    break;
                    case "rating":
                    audioBooks.Sort((a1, a2) => a1.Rating.CompareTo(a2.Rating));
                    break;
                }
            } else {
                switch (propertyType) {
                    case "title":
                    audioBooks.Sort((a1, a2) => a2.Title.CompareTo(a1.Title));
                    break;
                    case "artist":
                    audioBooks.Sort((a1, a2) => a2.Artist.CompareTo(a1.Artist));
                    break;
                    case "year":
                    audioBooks.Sort((a1, a2) => a2.Year.CompareTo(a1.Year));
                    break;
                    case "duration":
                    audioBooks.Sort((a1, a2) => a2.Duration.CompareTo(a1.Duration));
                    break;
                    case "rating":
                    audioBooks.Sort((a1, a2) => a2.Rating.CompareTo(a1.Rating));
                    break;
                }
            }
            audioBooks.ForEach(Console.WriteLine);
        } else {
            DisplayFunctions.DisplayError("Invalid Syntax");
        }
    }

    public void CreateMedia(string mediaType) {
        DisplayFunctions.ClearConsole();
        switch (mediaType) {
            case "track":
                try {
                    string title = DisplayFunctions.DisplayPromptResponse("Enter Track title");
                    string artist = DisplayFunctions.DisplayPromptResponse($"Enter '{title}'s artist name");
                    string album = DisplayFunctions.DisplayPromptResponse($"Enter '{title}'s album name");
                    int year = int.Parse(DisplayFunctions.DisplayPromptResponse($"Enter '{title}'s year (1900-{DateTime.Now.Year})"));
                    int duration = int.Parse(DisplayFunctions.DisplayPromptResponse($"Enter '{title}'s duration (>0)"));
                    double rating1 = double.Parse(DisplayFunctions.DisplayPromptResponse($"Enter '{title}' rating (0-5)"));
                    Track newTrack = new(title, artist, album, year, duration, rating1);
                } catch {
                    DisplayFunctions.DisplayError("Invalid Track syntax");
                    break;
                }
                break;
            case "podcast":
                try {
                    string title = DisplayFunctions.DisplayPromptResponse("Enter Podcast title");
                    string artist = DisplayFunctions.DisplayPromptResponse($"Enter '{title}'s creator name");
                    int year = int.Parse(DisplayFunctions.DisplayPromptResponse($"Enter '{title}'s year (1900-{DateTime.Now.Year})"));
                    int duration = int.Parse(DisplayFunctions.DisplayPromptResponse($"Enter '{title}'s duration (>0)"));
                    int rating2 = int.Parse(DisplayFunctions.DisplayPromptResponse($"Enter '{title}'s rating (0-5)"));
                    Podcast newPodcast = new(title, artist, year, duration, rating2);
                    podcasts.Add(newPodcast);
                } catch {
                    DisplayFunctions.DisplayError("Invalid Podcast syntax");
                    break;
                }
            break;
            case "audiobook":
                try { 
                    string title = DisplayFunctions.DisplayPromptResponse("Enter AudioBook title");
                    string artist = DisplayFunctions.DisplayPromptResponse($"Enter '{title}'s artist name");
                    int year = int.Parse(DisplayFunctions.DisplayPromptResponse($"Enter '{title}'s year (1900-{DateTime.Now.Year})"));
                    int duration = int.Parse(DisplayFunctions.DisplayPromptResponse($"Enter '{title}'s duration (>0)"));
                    int rating2 = int.Parse(DisplayFunctions.DisplayPromptResponse($"Enter '{title}'s rating (0-5)"));
                    AudioBook newAudioBook = new(title, artist, year, duration, rating2);
                    audioBooks.Add(newAudioBook);
                } catch {
                    DisplayFunctions.DisplayError("Invalid AudioBook syntax");
                    break;
                }
                break;
            default:
                DisplayFunctions.DisplayError("Invalid media type (track, podcast, audiobook)");
            break;
        }
    }

    public void RemoveMedia(string mediaType) {
        string title;
        bool mediaFound = false;
        switch (mediaType) {
            case "tracks":
                title = DisplayFunctions.DisplayPromptResponse("Enter Track title");
                if (string.IsNullOrWhiteSpace(title)) {
                    DisplayFunctions.DisplayError("Invalid title value (string)");
                    break;
                }

                for (int i = 0; i < tracks.Count; i++) {
                    if (tracks[i].Title == title) {
                        tracks.Remove(tracks[i]);
                        mediaFound = true;
                    }
                }

                DisplayFunctions.ClearConsole();
                if (mediaFound == false) {
                    DisplayFunctions.DisplayError($"{title} was not found in the Tracks library");
                } else {
                    Console.WriteLine($"{title} was successfully removed from the Tracks library");
                }
            break;
            case "podcasts":
                title = DisplayFunctions.DisplayPromptResponse("Enter Podcast title");
                if (string.IsNullOrWhiteSpace(title)) {
                    DisplayFunctions.DisplayError("Invalid title value (string)");
                    break;
                }

                for (int i = 0; i < podcasts.Count; i++) {
                    if (podcasts[i].Title.Equals(title, StringComparison.CurrentCultureIgnoreCase)) {
                        podcasts.Remove(podcasts[i]);
                        mediaFound = true;
                    }
                }

                DisplayFunctions.ClearConsole();
                if (mediaFound == false) {
                    DisplayFunctions.DisplayError($"{title} was not found in the Podcasts library");
                } else {
                    Console.WriteLine($"{title} was successfully removed from the Podcasts library");
            }
            break;
            case "audiobooks":
                title = DisplayFunctions.DisplayPromptResponse("Enter AudioBook title");
                if (string.IsNullOrWhiteSpace(title)) {
                    DisplayFunctions.DisplayError("Invalid title value (string)");
                    break;
                }

                for (int i = 0; i < audioBooks.Count; i++) {
                    if (audioBooks[i].Title.Contains(title)) {
                        audioBooks.Remove(audioBooks[i]);
                        mediaFound = true;
                    }
                }

                DisplayFunctions.ClearConsole();
                if (mediaFound == false) {
                    DisplayFunctions.DisplayError($"{title} was not found in the AudioBook library");
                } else {
                    Console.WriteLine($"{title} was successfully removed from the AudioBook library");
                }
                break;
            default:
                DisplayFunctions.DisplayError("Invalid media type (track, podcast, audiobook)");
            break;
        }
    }

    public void SearchMedia() {
        string searchCategory, itemName;
        searchCategory = DisplayFunctions.DisplayPromptResponse("Enter Propery name (title/artist/album/year/duration/rating)");
        itemName = DisplayFunctions.DisplayPromptResponse($"Enter {searchCategory} value (string)");
        if (string.IsNullOrWhiteSpace(searchCategory)) {
            DisplayFunctions.DisplayError("Invalid category value (title/artist/album/year/duration/rating)");
            return;
        }

        Console.WriteLine($"\tSEARCH RESULTS [{itemName}]");

        switch (searchCategory) {
            case "title":
                foreach (Track track in tracks) {
                    if (track.Title.Contains(itemName, StringComparison.CurrentCultureIgnoreCase)) {
                    Console.WriteLine(track);
                    }
                }
                foreach (Podcast podcast in podcasts) {
                    if (podcast.Title.Contains(itemName, StringComparison.CurrentCultureIgnoreCase)) {
                        Console.WriteLine(podcast);
                    }
                }
                foreach (AudioBook audioBook in audioBooks) {
                    if (audioBook.Title.Contains(itemName, StringComparison.CurrentCultureIgnoreCase)) {
                        Console.WriteLine(audioBook);
                    }
                }
                break;
            case "artist":
                foreach (Track track in tracks) {
                    if (track.Artist.Contains(itemName, StringComparison.CurrentCultureIgnoreCase)) {
                        Console.WriteLine(track);
                    }
                }
                foreach (AudioBook audioBook in audioBooks) {
                    if (audioBook.Artist.Contains(itemName, StringComparison.CurrentCultureIgnoreCase)) {
                        Console.WriteLine(audioBook);
                    }
                }
                break;
            case "creator":
                foreach (Podcast podcast in podcasts) {
                    if (podcast.Creator.Contains(itemName, StringComparison.CurrentCultureIgnoreCase)) {
                        Console.WriteLine(podcast);
                    }
                }
            break;
            case "album":
                foreach (Track track in tracks) {
                    if (track.Album.Contains(itemName, StringComparison.CurrentCultureIgnoreCase)) {
                        Console.WriteLine(track);
                    }
                }
                break;
            case "year":
                foreach (Track track in tracks) {
                    if (track.Year == int.Parse(itemName)) {
                        Console.WriteLine(track);
                    }
                }
                foreach (Podcast podcast in podcasts) {
                    if (podcast.Year == int.Parse(itemName)) {
                        Console.WriteLine(podcast);
                    }
                }
                foreach (AudioBook audioBook in audioBooks) {
                    if (audioBook.Year == int.Parse(itemName)) {
                        Console.WriteLine(audioBook);
                    }
                }
                break;
            case "duration":
                foreach (Track track in tracks) {
                    if (track.Duration == int.Parse(itemName)) {
                        Console.WriteLine(track);
                    }
                }
                foreach (Podcast podcast in podcasts) {
                    if (podcast.Duration == int.Parse(itemName)) {
                        Console.WriteLine(podcast);
                    }
                }
                foreach (AudioBook audioBook in audioBooks) {
                    if (audioBook.Duration == int.Parse(itemName)) {
                        Console.WriteLine(audioBook);
                    }
                }
                break;
            case "rating":
                foreach (Track track in tracks) {
                    if (track.Rating == double.Parse(itemName)) {
                        Console.WriteLine(track);
                    }
                }
                foreach (Podcast podcast in podcasts) {
                    if (podcast.Rating == int.Parse(itemName)) {
                        Console.WriteLine(podcast);
                    }
                }
                foreach (AudioBook audioBook in audioBooks) {
                    if (audioBook.Rating == int.Parse(itemName)) {
                        Console.WriteLine(audioBook);
                    }
                }
                break;
            default:
                DisplayFunctions.DisplayError("Invalid category value (title/artist/creator/album/year/duration/rating)");
                break;
        }
    }

    public void PlayMedia(string mediaType) {
        string fileName;
        string filePath;
        switch (mediaType) {
            case "track":
                fileName = DisplayFunctions.DisplayPromptResponse("Enter Track title to play");
                filePath = @$"audiofiles/tracks/{fileName}.mp3";
                foreach (Track track in tracks) {
                    if (track.Title.Contains(fileName)) {
                        Console.WriteLine($"\tCURRENTLY PLAYING [{track.Title}]");
                        Console.WriteLine(track);
                        ProgramFunctions.PlayMp3File(filePath);
                        return;
                    }
                }
                DisplayFunctions.DisplayError($"File {fileName} was not found in the Tracks Library");
                break;
            case "podcast":
                fileName = DisplayFunctions.DisplayPromptResponse("Enter Podcast title to play");
                filePath = @$"audiofiles/podcasts/{fileName}.mp3";
                foreach (Podcast podcast in podcasts) {
                    if (podcast.Title.Contains(fileName)) {
                        Console.WriteLine($"\tCURRENTLY PLAYING [{podcast.Title}]");
                        Console.WriteLine(podcast);
                        ProgramFunctions.PlayMp3File(filePath);
                        return;
                    }
                }
                DisplayFunctions.DisplayError($"File {fileName} was not found in the Podcasts Library");
                break;
            case "audiobook":
                fileName = DisplayFunctions.DisplayPromptResponse("Enter AudioBook title to play");
                filePath = @$"audiofiles/audiobooks/{fileName}.mp3";
                foreach (AudioBook audioBook in audioBooks) {
                    if (audioBook.Title.Contains(fileName)) {
                        Console.WriteLine($"\tCURRENTLY PLAYING [{audioBook.Title}]");
                        Console.WriteLine(audioBook);
                        ProgramFunctions.PlayMp3File(filePath);
                        return;
                    }
                }
                DisplayFunctions.DisplayError($"File {fileName} was not found in the AudioBooks Library");
                break;
            default:
                DisplayFunctions.DisplayError("Invalid media type (track, podcast, audiobook)");
                break;
        }
    }
    #endregion

    #region Properties
    public List<Track> Tracks {
        get => tracks;
        set {
            tracks = value;
        } 
    }
    public List<Podcast> Podcasts { 
        get => podcasts;
        set {
            podcasts = value;
        }
    }
    public List<AudioBook> AudioBooks {
        get => audioBooks;
        set {
            audioBooks = value;
        }
    }
    #endregion
}
