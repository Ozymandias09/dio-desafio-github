namespace RPG.src.entities
{
    public class Arus
    {
        public Arus(string Name, int level, string HeroType)
        {
            this.Name = Name;
            this.level = level;
            this.HeroType = HeroType;
        }
        public string Name { get; set; }
        public int level { get; set; }
        public string HeroType { get; set; }

        public override string ToString() { 
            return this.Name+" "+ this.level+" "+this.HeroType;
         }
         
        public string Attack(){
            return this.Name+ "Atacou coma a sua espada";
        }
        
        
        
        
        
        
    }
}