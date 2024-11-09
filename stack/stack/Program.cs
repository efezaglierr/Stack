using System;
using System.Collections;
using System.Diagnostics;

public class Stack
{
    public ArrayList liste;
    private int p_index;
    private int kapasite;

    public Stack(int kapasite)
    {
        this.kapasite = kapasite;
        liste = new ArrayList();
        p_index = -1;
    }

    public void Push(object eleman)
    {
        liste.Add(eleman);
        p_index++;

    }

    public object Pop()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Yığın Boş! Eleman çıkarılamaz.");
            throw new InvalidOperationException("Yığın boş.");
        }

        object obj = liste[p_index];
        liste.RemoveAt(p_index);
        p_index--;
        return obj;

    }

    public void Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Yığın Boş.");
            throw new InvalidOperationException("Yığın boş.");
        }
        else
        {
            Console.WriteLine($"Stackteki En Üst Değer : {liste[p_index]}");
        }
    }

    public bool IsEmpty()
    {
        return p_index == -1;
    }

    public bool IsFull()
    {

        return kapasite == p_index - 1;


    }



    public int Size()
    {
        return p_index + 1;
    }

    public void Clear()
    {
        liste.Clear();
        p_index = -1;
    }

    public void Display()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Stack Boş");
        }
        else
        {
            Console.Write("Stack Son Hali  =  [  ");
            foreach (var i in liste)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("  ]\n");
        }
    }

    public class Program
    {
        public static void Main()
        {
            string deger;

            Stack st = new Stack(5);

            st.Push(10);
            st.Push(20);
            st.Push(30);
            st.Push(40);
            st.Push(50);
            st.Push(60);

            st.Peek();
            deger = st.IsFull() ? "Dolu" : "Değil";
            Console.WriteLine("Çıkarılan eleman: " + st.Pop());

            Console.WriteLine("Yığın boş mu? " + st.IsEmpty());

            Console.WriteLine("Yığının boyutu: " + st.Size());

            Console.WriteLine($"Yığın Dolu Mu :{deger}");
            st.Display();

            Console.ReadLine();
        }
    }
}
