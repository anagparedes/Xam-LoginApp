
using LoginApp.Models;


namespace LoginApp.ViewModels
{
    public class HomeViewModel 

    {
        public MenuOption Game1 { get; set; } = new MenuOption();
        public MenuOption Game2 { get; set; } = new MenuOption();
        public MenuOption Game3 { get; set; } = new MenuOption();
        public MenuOption Game4 { get; set; } = new MenuOption();
        public MenuOption Game5 { get; set; } = new MenuOption();
        public MenuOption Game6 { get; set; } = new MenuOption();

        public HomeViewModel()
        {
            Game1.Title = "MarioKart";
            Game1.Image = "mariokart.jpg";
            Game2.Title = "Pokemon Black Version";
            Game2.Image = "pokemon.jpg";
            Game3.Title = "Animal Crossing";
            Game3.Image = "crossing.jpg";
            Game4.Title = "The Legend of Zelda";
            Game4.Image = "zelda.jpg";
            Game5.Title = "Metroid Prime";
            Game5.Image = "metroid.jpg";
            Game6.Title = "Castlevania";
            Game6.Image = "castlevania.jpg";
           

        }


       
        





    }

    
}