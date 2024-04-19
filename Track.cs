public class Track {
    private string title;
    private string artist;
    private string album;
    private int year;
    private int duration;
    private double rating;

    public Track(string title, string artist, string album, int year, int duration, double rating) {
        Title = title;
        Artist = artist;
        Album = album;
        Year = year;
        Duration = duration;
        Rating = rating;
    }

    public override string ToString() {
        return $"> {title} ({year})\t|  {artist}\t|  {album}\t|  {duration} Minutes\t|  {rating} Stars";
    }

    public string Title {
        get => title;
        set {
            if (string.IsNullOrWhiteSpace(value)) {
                DisplayFunctions.DisplayError("Invalid title name (string)");
            } else {
                title = value;
            }
        }
    }
    public string Artist {
        get => artist;
        set {
            if (string.IsNullOrWhiteSpace(value)) {
                DisplayFunctions.DisplayError("Invalid artist name (string)");
            } else {
                artist = value;
            }
        }
    }
    public string Album {
        get => album;
        set {
            if (string.IsNullOrWhiteSpace(value)) {
                DisplayFunctions.DisplayError("Invalid album name (string)");
            } else {
                album = value;
            }
        }
    }
    public int Year {
        get => year;
        set {
            if (value.GetType() != typeof(int)) {
                DisplayFunctions.DisplayError("Invalid year type (int)");
            } else if (value < 1900 || value > DateTime.Now.Year) {
                DisplayFunctions.DisplayError($"Invalid year type (1900-{DateTime.Now.Year})");
            } else {
                year = value;
            }
        }
    }
    public int Duration {
        get => duration;
        set {
            if (value.GetType() != typeof(int)) {
                DisplayFunctions.DisplayError("Invalid duration type (int)");
            } else if (value < 0) {
                DisplayFunctions.DisplayError("Invalid duration value (>0)");
            } else {
                duration = value;
            }
        }
    }
    public double Rating {
        get => rating;
        set {
            if (value.GetType() != typeof(double)) {
                DisplayFunctions.DisplayError("Invalid rating type (double)");
            } else if (value < 0 || value > 5) {
                DisplayFunctions.DisplayError("Invalid rating value (0-5)");
            } else {
                rating = value;
            }
        }
    }
}