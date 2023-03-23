using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiczenieMacierzy
{
    public readonly struct Class1
    {
        private int A { get; init; }
        private int B { get; init; }
        private int C { get; init; }
        private int D { get; init; }
        public Class1(int a , int b, int c, int d) 
        { 
            A = a;
            B = b;
            C = c;
            D = d;
        }
        public Class1() 
        {
            A = 1;
            B = 0;
            C = 0;
            D = 1;
        }
        public static Class1 Id { get; } = new Class1();
        public override string ToString()
        {
            return string.Format("[0], [1], [2], [3]", A,B,C,D);
        }

        public override bool Equals(object? obj)
        {
            return obj is Class1 macierz &&
                A == macierz.A &&
                B == macierz.B &&
                C == macierz.C &&
                D == macierz.D;
        }
    }
}
