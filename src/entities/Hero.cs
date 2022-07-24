
namespace desafio_dotnet_dio.src.entities
{
    public abstract class Hero
    {

       public Hero(string Name, int Level, string HeroType){
       
        this.Name = Name;
        this.Level = Level;
        this.HeroType = HeroType;

       }

        public string Name;
        public int Level;
        public string HeroType;


                public  virtual string attack(){
            return this.Name +" "+ "atacou com a sua espada";
        }

    }
}