using System;

internal class Program
{
    static string[] stack = new string[100]; 
    static int stackpointer = -1;

    static void Main(string[] args)
    {
        string operatör = "-+/*"; // Operatörler
        string postfix =  "abc*df-/+"; // Postfix bunu infix'e çevireceğiz.
        for (int i = 0; i < postfix.Length; i++)
        {
            char ch = postfix[i];
            int indis = operatör.IndexOf(ch);
            if (indis ==-1)
            {
                Push(ch.ToString());
            }
            else
            {
                string operand2 = Pop();
                string operand1 = Pop();
                string ifade = "(" + operand1 + ch + operand2 + ")";
                Push(ifade);

            }
        }
        string infix = Pop();

        Console.WriteLine("Infix: " + infix);

    }
    
    static string Top()
    {
        return stack[stackpointer];
    }

    // Yığına eleman ekleme
    static void Push(string data)
    {
        stackpointer++;
        stack[stackpointer] = data;
    }

    // Yığından eleman çıkarma
    static string Pop()
    {
        string value = stack[stackpointer];
        stackpointer--;
        return value;
    }
}