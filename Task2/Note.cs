using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Note
    {
        public int Frequency { get; private set; }
        public int Duration { get; private set; }
        public bool Pause { get; private set; }

        public Note(int frequency, int duration, bool pause)
        {
            Frequency = frequency;
            Duration = duration;
            Pause = pause;
        }

        public static Note Do(int octave, int duration)
        {
            int frequency = (octave) switch
            {
                1 => 261,
                2 => 523,
                3 => 1046,
                4 => 2093,
                5 => 4186,
                _ => 261,
            };
            return new Note(frequency, duration, false);
        }
        public static Note Re(int octave, int duration)
        {
            int frequency = (octave) switch
            {
                1 => 261,
                2 => 523,
                3 => 1046,
                4 => 2093,
                5 => 4186,
                _ => 261,
            };
            return new Note(frequency, duration, false);
        }
        public static Note Mi(int octave, int duration)
        {
            int frequency = (octave) switch
            {
                1 => 261,
                2 => 523,
                3 => 1046,
                4 => 2093,
                5 => 4186,
                _ => 261,
            };
            return new Note(frequency, duration, false);
        }
        public static Note Fa(int octave, int duration)
        {
            int frequency = (octave) switch
            {
                1 => 261,
                2 => 523,
                3 => 1046,
                4 => 2093,
                5 => 4186,
                _ => 261,
            };
            return new Note(frequency, duration, false);
        }
        public static Note Sol(int octave, int duration)
        {
            int frequency = (octave) switch
            {
                1 => 261,
                2 => 523,
                3 => 1046,
                4 => 2093,
                5 => 4186,
                _ => 261,
            };
            return new Note(frequency, duration, false);
        }
        public static Note Lya(int octave, int duration)
        {
            int frequency = (octave) switch
            {
                1 => 261,
                2 => 523,
                3 => 1046,
                4 => 2093,
                5 => 4186,
                _ => 261,
            };
            return new Note(frequency, duration, false);
        }
        public static Note Si(int octave, int duration)
        {
            int frequency = (octave) switch
            {
                1 => 261,
                2 => 523,
                3 => 1046,
                4 => 2093,
                5 => 4186,
                _ => 261,
            };
            return new Note(frequency, duration, false);
        }
    }
}
