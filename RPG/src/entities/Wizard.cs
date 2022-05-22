namespace RPG.src.entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int level, string HeroType)
        {
            ThreadStaticAttribute.Name = Name;
            this.level = level;
            this.HeroType = HeroType;
        }
        
         public override string Attack(){
            return this.Name + "Lançou Magia!";
        
        }
    
    }

}
