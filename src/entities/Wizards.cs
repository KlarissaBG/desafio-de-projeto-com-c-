namespace desafio_dotnet_dio.src.entities
{
    public class Wizards : Hero
    {
        public Wizards(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
        }

        public override string attack(){
            return this.Name +" "+ "lançou magia";
        }

        public string attack(int Bonus){
            if (Bonus > 6){
                return this.Name +" "+ "lançou magia super efetiva com bonus de ataque de"+" " + Bonus;
            }else{
                return this.Name +" "+ "lançou magia com força fraca com bonus de"+" " + Bonus;
            }
           
        }
    }
}