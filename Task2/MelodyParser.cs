using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    static class MelodyParser
    {
        public static Note[] ParseMelody(string melody)
        {
            Note[] notes = new Note[melody.Length];
            for (int i = 0; i < notes.Length; i++)
            {
                Note note = (Convert.ToInt32(melody[i])) switch
                {
                    1 => Note.Do(1, 1),
                    2 => Note.Re(1, 1),
                    3 => Note.Mi(1, 1),
                    4 => Note.Fa(1, 1),
                    5 => Note.Sol(1, 1),
                    6 => Note.Lya(1, 1),
                    7 => Note.Si(1, 1),
                    8 => Note.Do(1, 1),
                    9 => Note.Re(1, 1),
                    0 => Note.Mi(1, 1),
                    _ => new Note(1, 1, true)
                };
            }
            return notes;
        }
    }
}
