namespace ExemploConstrutores.Models
{
    public class Pessoa
    {
        private static Pessoa _pessoa;
        public string PropriedaPessoa { get; set; }
        private Pessoa()
        {
        }

        public static Pessoa GetInstace(){
            if(_pessoa == null){

                _pessoa = new Pessoa();
            }
            return _pessoa!;
        }


    }
}