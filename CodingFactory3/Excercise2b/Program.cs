namespace Excercise2b
{
    internal class Program
    {
        static int[] queue = new int[50];
        static int top = -1;

        public static void Main(string[] args)
        {
            int num = 0;

            Enqueue(1);
            Enqueue(2);
            Enqueue(3);

            num = Dequeue();
            Console.WriteLine(num);
            PrintQueue();
        }

        public static void Enqueue(int val)
        {
            if (!IsFull())
            {
                queue[++top] = val;
            }
            else
            {
                Console.WriteLine("queue is full");
            }
        }

        public static int Dequeue()
        {
            int num = 0;

            if (!IsEmpty())
            {
                num = queue[0];
                Array.Copy(queue, 1, queue, 0, top);
                top--;
                return num;
            }
            else
            {
                throw new Exception("queue is empty");
            }
        }

        public static bool IsFull()
        {
            return (top == (queue.Length - 1));
        }

        public static bool IsEmpty()
        {
            return (top == -1);
        }

        public static void PrintQueue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("queue is empty");
                return;
            }

            for (int i = 0; i <= top; i++)
            {
                Console.Write(queue[i] + " ");
            }

            Console.WriteLine();
        }
    }
}