using System;

namespace ChooseYourScenario.Models
{
    class Game
    {
        public string UserName { get; set; }
        public string CatName { get; set; }

        public Game ()
        {
            UserName = "";
            CatName = "";
        }
    }
}