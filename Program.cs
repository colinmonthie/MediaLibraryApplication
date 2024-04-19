public static class Program {
    private static void Main() {
        bool RUNNING = true;
        MediaLibrary mediaLibrary = MediaLibrary.LoadLibrary();
        DisplayFunctions.ClearConsole();
        DisplayFunctions.DisplayHelp();
        while (RUNNING) {
            RUNNING = ProgramFunctions.UserInput(mediaLibrary);
        }


        

        // Lists to store tracks, audiobooks, and podcasts

        /* Stretch Goals
         * 3) Use 'TimeSpan' struct to handle duration
         * 4) Use 'DateTime' struct to replace year
         * 7) Add filepath with media that can be played in GUI
         * 8) Add filepath with album art that can be showed in GUI
         */
    }
}