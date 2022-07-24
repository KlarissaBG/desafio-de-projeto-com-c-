namespace desafio_dotnet_dio.src.entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
        }

         public override string attack(){
            return this.Name +" "+ "lançou um golpe ninja";
        }
    }
}