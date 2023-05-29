namespace Excercise2a
{
    internal class Program
    {
        static int[] stack = new int[50];
        static int top = -1;

        public static void Main(string[] args)
        {
            int num = 0;

            Push(1);
            Push(2);
            Push(10);
            Push(50);
            Push(20);
            Push(3);
            num = Pop();
            num = Pop();
            Console.WriteLine(num);

            PrintStack();
        }

        public static void Push(int num)
        {
            if (!IsFull())
            {
                stack[++top] = num;
            }
            else
            {
                throw new Exception();
            }
        }

        public static int Pop()
        {
            if (!IsEmpty())
            {
                return stack[top--];
            }
            else
            {
                throw new Exception();
            }
        }

        public static bool IsFull()
        {
            return (top == (stack.Length - 1));
        }

        public static bool IsEmpty()
        {
            return (top == -1);
        }

        public static void PrintStack()
        {
            if (IsEmpty())
            {
                Console.WriteLine("stack is empty");
                return;
            }

            for (int i = 0; i <= top; i++)
            {
                Console.Write(stack[i] + " ");
            }

            Console.WriteLine();
        }
    }
}