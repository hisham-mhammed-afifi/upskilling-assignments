namespace Advanced.MediaPlayer
{

    public interface IMedia
    {
        void Play();
        void Stop();
    }

    public class Audio : IMedia
    {
        public void Play()
        {
            Console.WriteLine("Playing audio...");
        }

        public void Stop()
        {
            Console.WriteLine("Stopping audio.");
        }
    }

    public class Video : IMedia
    {
        public void Play()
        {
            Console.WriteLine("Playing video...");
        }

        public void Stop()
        {
            Console.WriteLine("Stopping video.");
        }
    }

    public class Podcast : IMedia
    {
        public void Play()
        {
            Console.WriteLine("Playing podcast...");
        }

        public void Stop()
        {
            Console.WriteLine("Stopping podcast.");
        }
    }

    public class LiveStream : IMedia
    {
        public void Play()
        {
            Console.WriteLine("Starting live stream...");
        }

        public void Stop()
        {
            Console.WriteLine("Ending live stream.");
        }
    }

    public class MediaPlayer
    {
        private readonly IMedia _media;

        public MediaPlayer(IMedia media)
        {
            _media = media;
        }

        public void PlayMedia()
        {
            _media.Play();
        }

        public void StopMedia()
        {
            _media.Stop();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose Media Type: 1- Audio, 2- Video, 3- Podcast, 4- LiveStream");
            string choice = Console.ReadLine();

            IMedia selectedMedia;
            switch (choice)
            {
                case "1":
                    selectedMedia = new Audio();
                    break;
                case "2":
                    selectedMedia = new Video();
                    break;
                case "3":
                    selectedMedia = new Podcast();
                    break;
                case "4":
                    selectedMedia = new LiveStream();
                    break;

                default:
                    throw new ArgumentException("Invalid media type selected!");
            }


            MediaPlayer player = new MediaPlayer(selectedMedia);

            Console.WriteLine("Press P to Play or S to Stop.");
            while (true)
            {
                char command = Console.ReadKey().KeyChar;
                Console.WriteLine();
                if (command == 'P' || command == 'p')
                {
                    player.PlayMedia();
                }
                else if (command == 'S' || command == 's')
                {
                    player.StopMedia();
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid command! Press P to Play or S to Stop.");
                }
            }
        }
    }
}
