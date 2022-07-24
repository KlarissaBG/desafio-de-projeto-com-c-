namespace desafio_dotnet_dio.src.entities
{
    public class BlackWizard : Hero
    {
        public BlackWizard(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
        }

         public override string attack(){
            return this.Name +" "+ "lançou magia negra";
        }

        public string attack(int Bonus){
            if (Bonus > 6){
                return this.Name +" "+ "lançou magia negra super efetiva com bonus de ataque de"+" " + Bonus;
            }else{
                return this.Name +" "+ "lançou magia negra com força fraca com bonus de"+" " + Bonus;
            }
           
        }
    }
}