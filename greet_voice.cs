using System;
using System.IO;
using System.Media;

namespace CyberSecurity_Chatbot
{
    public class greet_voice
    {
        public void play_voice()
        {
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "greeting.wav");
                Console.WriteLine("Looking for audio at: " + path);

                if (!File.Exists(path))
                {
                    Console.WriteLine("Audio file not found. Ensure 'greeting.wav' is present and set its properties in Solution Explorer: Build Action = Content and _Copy to Output Directory_ = Copy always (or Copy if newer).");
                    return;
                }

                using (var player = new SoundPlayer(path))
                {
                    // Load will throw if the file is not a valid WAV or cannot be read
                    player.Load();
                    player.PlaySync();
                }
            }
            catch (FileNotFoundException fnf)
            {
                Console.WriteLine("Audio file missing: " + fnf.Message);
            }
            catch (InvalidOperationException ioe)
            {
                Console.WriteLine("Audio format error (unsupported WAV): " + ioe.Message);
                Console.WriteLine("Convert the file to PCM WAV (16-bit) and try again.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Audio error: " + ex.Message);
            }
        }
    }
}