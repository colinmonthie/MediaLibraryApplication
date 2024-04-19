public class AudioBook {
    private string title;
    private string artist;
    private int year;
    private int duration;
    private int rating;

    public AudioBook(string title, string artist, int year, int duration, int rating) {
        Title = title;
        Artist = artist;
        Year = year;
        Duration = duration;
        Rating = rating;
    }

    public override string ToString() {
        return $"> {title} ({year})\t|  {artist}\t|  {duration} Minutes\t|  {rating} Stars";
    }

    public string Title {
        get => title;
        set {
            if (string.IsNullOrWhiteSpace(value)) {
                DisplayFunctions.DisplayError("Invalid title value (string)");
            } else {
                title = value;
            }
        }
    }
    public string Artist {
        get => artist;
        set {
            if (string.IsNullOrWhiteSpace(value)) {
                DisplayFunctions.DisplayError("Invalid artist value (string)");
            } else {
                artist = value;
            }
        }
    }
    public int Year {
        get => year;
        set {
            if (value.GetType() != typeof(int)) {
                DisplayFunctions.DisplayError("Invalid year type (int)");
            } else if (value < 1900 || value > DateTime.Now.Year) {
                DisplayFunctions.DisplayError($"Invalid year value (1900-{DateTime.Now.Year}");
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
    public int Rating {
        get => rating;
        set {
            if (value.GetType() != typeof(int)) {
                DisplayFunctions.DisplayError("Invalid rating type (int)");
            } else if (value != 0 && value != 1) {
                DisplayFunctions.DisplayError("Invalid rating vlaue (0 or 1)");
            } else {
                rating = value;
            }
        }
    }
}
