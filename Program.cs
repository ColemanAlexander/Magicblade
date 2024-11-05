namespace Magicblade 
{
    public class Magicblade
    {
        public static void Main() 
        {
            Player player = new Player() {
                Name = "Player",
                Health = 100,
                Energy = 5,
                Deck = new(),
            };
            Guard guard = new Guard(){
                Name = "guard",
                Health = 10,
                Energy = 2,
                Deck = new(),
            };

            Card QuickStab = new() {
                Name = "QuickStab",
                Type = "Attack",
                Description = "Light attack",
                Effect = -10,
                Cost = 1
            };
            Card HardBlow = new() {
                Name = "HardBlow",
                Type = "Attack",
                Description = "Heavy attack",
                Effect = -25,
                Cost = 3
            };

            
            Card Block = new() {
                Name = "Block",
                Type = "Defence",
                Description = "Adds 2 armor",
                Effect = 2,
                Cost = 1
            };

            Card Parry = new() {
                Name = "Parry",
                Type = "Defense",
                Description = "Negates next attack",
                Effect = 99,
                Cost = 5
            };


            player.Deck.Cards.Add(QuickStab);
            player.Deck.Cards.Add(QuickStab);
            player.Deck.Cards.Add(HardBlow);
            player.Deck.Cards.Add(Block);
            player.Deck.Cards.Add(Block);
            player.Deck.Cards.Add(Parry);

            guard.Deck.Cards.Add(QuickStab);
            guard.Deck.Cards.Add(QuickStab);
            guard.Deck.Cards.Add(QuickStab);


            Console.WriteLine("MagicBlade");
            Console.WriteLine();
            Console.WriteLine("Begin climb");
            Console.WriteLine("PRESS ANY KEY TO CONTINUE");
            Console.ReadKey();
            Console.Clear();

            while (player.Health>0||guard.Health>0)
            {
                Console.WriteLine("YOUR TURN:");
                Console.WriteLine();


            }
        }
    }
}