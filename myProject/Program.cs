
using System;

namespace myProject
{

    class Game
    {

        private int _Id;
        private string _Title;
        private string _Author;

        public Game()
        {
            _Id = 0;
            _Title = "";
            _Author = "";
        }

        public Game(int id, string title, string author)
        {
            _Id = id;
            _Title = title;
            _Author = author;
        }

        public int GetId()
        {
            return _Id;
        }

        public string GetTitle()
        {
            return _Title;
        }

        public string GetAuthor()
        {
            return _Author;
        }

        public void SetId(int id)
        {
            _Id = id;
        }

        public void SetTitle(string title)
        {
            _Title = title;
        }

        public void SetAuthor(string author)
        {
            _Author = author;
        }
    }
    class myGames
    {
        static void Main(string[] args)
        {
            Game newGame = new Game();
            newGame.SetId(1);
            newGame.SetTitle("Super Square");
            newGame.SetAuthor("Mr. Cube");

            // Game 2
            Game twoGame = new Game();
            Console.WriteLine("Please insert the Game ID: ");
            twoGame.SetId(int.Parse(Console.ReadLine()));
            Console.WriteLine("Please insert the Game title: ");
            twoGame.SetTitle(Console.ReadLine());
            Console.WriteLine("Please insert the Game author: ");
            twoGame.SetAuthor(Console.ReadLine());

            // Game 3
            Game threeGame = new Game(3, "Game3", "Author3");

            // Game 4
            Console.WriteLine("Please insert the Game ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Please insert the Game title: ");
            string title = Console.ReadLine();
            Console.WriteLine("Please insert the Game author: ");
            string author = Console.ReadLine();
            Game fourGame = new Game(id, title, author);

            displayGames(newGame);
            displayGames(twoGame);
            displayGames(threeGame);
            displayGames(fourGame);
        }

        static void displayGames(Game Gamenum)
        {
            Console.WriteLine("// Game Info //");
            Console.WriteLine(Gamenum.GetId());
            Console.WriteLine(Gamenum.GetTitle());
            Console.WriteLine(Gamenum.GetAuthor());
        }
    }
}