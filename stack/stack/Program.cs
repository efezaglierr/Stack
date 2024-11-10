using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;

public class Stack
{
    public ArrayList liste;
    public int p_index;
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
            return true;

        }
        else
        { 
            object ?obj = liste[p_index];
            liste.RemoveAt(p_index);
            p_index--;
            return obj;


        }



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
        if(p_index == -1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool IsFull()
    {

        return p_index == kapasite - 1;


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


}

public class PalindromeChecker
{
    public void IsPalindrome(string kelime)
    {
        Stack st1 = new Stack(kelime.Length);
        Stack st2 = new Stack(kelime.Length);

        for (int i = 0; i < kelime.Length; i++)
        {
            st1.Push(kelime.Substring(i, 1));
        }
        for (int j = kelime.Length - 1; j >= 0; j--)
        {
            st2.Push(kelime.Substring(j, 1));

        }
        bool palindrom = true;

        while (!st1.IsEmpty() && !st2.IsEmpty())
        {
            object cikan1;
            object cikan2;
            cikan1 = st1.Pop();
            cikan2 = st2.Pop();

            if (cikan1.ToString().ToLower() != cikan2.ToString().ToLower())
            {
                palindrom = false;
                break;

            }

        }

        if (palindrom)
        {
            Console.WriteLine("Kelime Palindromdur");
        }
        else
        {
            Console.WriteLine("Kelime Palindrom Değildir");
        }

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

            Console.Write("Palindrom Kelime Kontrolü İçin Kelime Giriniz : ");



            PalindromeChecker  kelime = new PalindromeChecker();
            string checkval = kelime.ToString();
            checkval = Console.ReadLine();
          
            kelime.IsPalindrome(checkval);

            Console.ReadLine();
       
        }
    }



