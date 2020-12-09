namespace AulaPOO_Encapsulamento.classes
{
    public class MasterCard : Cartao
    {   
        //atributos
        private int parcelas;

        //get e set

        public int Parcelas{
            get{return parcelas;} // pegar dados - leitura
            set{parcelas = value;}// inserir dados- escrita
        }

        public string CompraComDesconto(){
            return "";
        }
    }
}