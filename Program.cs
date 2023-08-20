using System.Collections;
using System;


namespace QueueTypeDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue que = new Queue(5,3F); //Kapasite:5 , BüyümeKatsayısı: 3
            que.Enqueue("C"); //ElemanEklemek
            que.Enqueue("S"); //ElemanEklemek
            que.Enqueue("A"); //ElemanEklemek
            que.Enqueue("R"); //ElemanEklemek
            que.Enqueue("P"); //ElemanEklemek
            que.Enqueue("H"); //ElemanEklemek


            Console.WriteLine(que.Count);
            Console.WriteLine(que.Peek().ToString());//iLK ELEMANI getirir
            Console.WriteLine(que.Peek().ToString());
            Console.WriteLine(que.Peek().ToString());
            Console.WriteLine(que.Peek().ToString());
            Console.WriteLine(que.Peek().ToString());
            Console.WriteLine(que.Peek().ToString());
            Console.WriteLine(que.Count);

            Console.WriteLine(que.Count);
            Console.WriteLine(que.Dequeue().ToString());//iLK ELEMANI getirir
            Console.WriteLine(que.Dequeue().ToString());//Sıradaki ELEMANI getirir
            Console.WriteLine(que.Dequeue().ToString());//Sıradaki ELEMANI getirir
            Console.WriteLine(que.Dequeue().ToString());//Sıradaki ELEMANI getirir
            Console.WriteLine(que.Dequeue().ToString());//Sıradaki ELEMANI getirir
            Console.WriteLine(que.Dequeue().ToString());//Sıradaki ELEMANI getirir
            Console.WriteLine(que.Count);



            Console.WriteLine("---------------------MyFifo----------------------");

            FifoContainer fifo = new FifoContainer();
            Console.WriteLine("Capasity , " + fifo.Count);

            fifo.Enqueue("A");
            Console.WriteLine("Add A,  Capasity , " + fifo.Count);

            fifo.Enqueue("B");
            Console.WriteLine("Add B , Capasity , " + fifo.Count);

            fifo.Enqueue("C");
            Console.WriteLine("Add C , Capasity , " + fifo.Count);

            fifo.Enqueue("D");
            Console.WriteLine("Add D ,Capasity , " + fifo.Count);


            Console.WriteLine($"{fifo.Peek()}, Capasity: {fifo.Count}");
            Console.WriteLine($"{fifo.Peek()}, Capasity: {fifo.Count}");
            Console.WriteLine($"{fifo.Peek()}, Capasity: {fifo.Count}");
            Console.WriteLine($"{fifo.Peek()}, Capasity: {fifo.Count}");
            Console.WriteLine($"{fifo.Peek()}, Capasity: {fifo.Count}");
            Console.WriteLine($"{fifo.Peek()}, Capasity: {fifo.Count}");
            Console.WriteLine($"{fifo.Peek()}, Capasity: {fifo.Count}");
            Console.WriteLine($"{fifo.Peek()}, Capasity: {fifo.Count}");
            Console.WriteLine($"{fifo.Peek()}, Capasity: {fifo.Count}");
            Console.WriteLine($"{fifo.Dequeue()}, Capasity: {fifo.Count}");
            Console.WriteLine($"{fifo.Dequeue()}, Capasity: {fifo.Count}");
            Console.WriteLine($"{fifo.Dequeue()}, Capasity: {fifo.Count}");
            Console.WriteLine($"{fifo.Dequeue()}, Capasity: {fifo.Count}");
            Console.WriteLine($"{fifo.Dequeue()}, Capasity: {fifo.Count}");



            Console.WriteLine("---------------------MyLifo----------------------");

            LifoContainer lifo = new LifoContainer();
            Console.WriteLine("Capasity , " + lifo.Count);

            lifo.Push("A");
            Console.WriteLine("Add A,  Capasity , " + lifo.Count);

            lifo.Push("B");
            Console.WriteLine("Add B , Capasity , " + lifo.Count);

            lifo.Push("C");
            Console.WriteLine("Add C , Capasity , " + lifo.Count);

            lifo.Push("D");
            Console.WriteLine("Add D ,Capasity , " + lifo.Count);

            lifo.Push("E");
            Console.WriteLine("Add E ,Capasity , " + lifo.Count);

            lifo.Push("F");
            Console.WriteLine("Add F ,Capasity , " + lifo.Count);


            
            Console.WriteLine($"Pop: {lifo.Pop().ToString()} ,Capasity: {lifo.Count} ");
            Console.WriteLine($"Pop: {lifo.Pop().ToString()} ,Capasity: {lifo.Count} ");
            Console.WriteLine($"Pop: {lifo.Pop().ToString()} ,Capasity: {lifo.Count} ");
            Console.WriteLine($"Pop: {lifo.Pop().ToString()} ,Capasity: {lifo.Count} ");
            Console.WriteLine($"Pop: {lifo.Pop().ToString()} ,Capasity: {lifo.Count} ");
            Console.WriteLine($"Pop: {lifo.Pop().ToString()} ,Capasity: {lifo.Count} ");
            Console.WriteLine($"Pop: {lifo.Pop().ToString()} ,Capasity: {lifo.Count} ");
            Console.WriteLine($"Pop: {lifo.Pop().ToString()} ,Capasity: {lifo.Count} ");
            Console.WriteLine($"Pop: {lifo.Pop().ToString()} ,Capasity: {lifo.Count} ");

            lifo.Push("F");
            Console.WriteLine("Add F ,Capasity , " + lifo.Count);
        }
    }
}
