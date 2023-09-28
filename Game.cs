using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Game
    {
        //puts  the string "Title", the character "Esrb" and the string "Genre".
        public string Title { get; }

        public char Esrb { get; }

        public string Genre { get; }

        //change Title, Esrb and Genre to Params.
        public Game(string titleParam, char esrbParam, string genreParam)
        {
            Title = titleParam;
            Esrb = esrbParam;
            Genre = genreParam;
        }

    }
}