namespace AulaPOO_Encapsulamento.classes
{
    public class Cartao
    {
        private string numero;

        private string bandeira = "MasterCard";

        public string Bandeira{
            get{return bandeira;}
            set{bandeira = value;}
            }

        protected string token = "qwertyui";

        public string Token{get;set}

        private string cvv;

        protected float limite = 5000;

        public string RegistarCompra(bool validado){
            return "";
            
        }
        }
    }
}