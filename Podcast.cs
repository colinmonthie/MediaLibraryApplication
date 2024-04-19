public class Podcast {
    private string title;
    private string creator;
    private int year;
    private int duration;
    private int rating;

    public Podcast(string title, string creator, int year, int duration, int rating) {
        Title = title;
        Creator = creator;
        Year = year;
        Duration = duration;
        Rating = rating;
    }

    public override string ToString() {
        return $"> {title} ({year})\t|  {creator}\t|  {duration} Minutes\t|  {rating} Stars";
    }

    public string Title {
        get => title;
        set {
            if (string.IsNullOrEmpty(value)) {
                DisplayFunctions.DisplayError("Invalid title value (string)");
            } else {
                title = value;
            }
        }
    }
    public string Creator {
        get => creator;
        set {
            if (string.IsNullOrEmpty(value)) {
                DisplayFunctions.DisplayError("Invalid creator value (string)");
            } else {
                creator = value;
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
    public int Rating {
        get => rating;
        set {
            if (value.GetType() != typeof(int)) {
                DisplayFunctions.DisplayError("Invalid rating type (double)");
            } else if (value < 0 || value > 10) {
                DisplayFunctions.DisplayError("Invalid rating value (0-5)");
            } else {
                rating = value;
            }
        }
    }
}