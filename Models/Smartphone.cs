namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string _Modelo;
        public string modelo
        {
            get { return _Modelo; }
            set { _Modelo = value; }
        }

        private string _IMEI;
        public string imei
        {
            get { return _IMEI; }
            set { _IMEI = value; }
        }

        private int _Memoria;
        public int memoria
        {
            get { return _Memoria; }
            set { _Memoria = value; }
        }
        
        
        

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            this.Numero = numero;
            this._Modelo = modelo;
            this._IMEI = imei;
            this._Memoria = memoria;

        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}