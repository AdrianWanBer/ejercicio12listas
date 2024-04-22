namespace ejercicio12listas
{
    class program
    {
        public static void Main(String[] args) {
        
            Queue<String> cola = new Queue<String>();

            cola.Enqueue("Cliente 1");
            cola.Enqueue("Cliente 2");
            cola.Enqueue("Cliente 3");

            //Primero en entrar
            Console.WriteLine(cola.Peek());
            //Ha salido de la tienda
            cola.Dequeue();
            //Ahora va el siguien
            Console.WriteLine(cola.Peek());

        }
    }
}