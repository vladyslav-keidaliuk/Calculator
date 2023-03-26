using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Fraction
    {
        //Оголошення змінної класу, типу даних int, що зберігає чисельник дробу
        private int numerator;
        // Оголошення змінної класу, типу даних int, що зберігає знаменник дробу
        private int denominator;
        // Оголошення змінної класу, типу даних int, що зберігає цілу частину дробу
        private int whole;
        // Оголошення конструктора за замовчуванням
        public Fraction()
        {
            numerator = 0;
            denominator = 1;
            whole = 0;
            // Ініціалізувати змінну numerator, значенням 0
            // Ініціалізувати змінну denominator, значенням 1
            // Ініціалізувати змінну whole, значенням 0
        }
        // Оголошення параметризованого конструктора
        public Fraction(int whole)
        {
            numerator = 0;
            denominator = 1;
            this.whole = whole;
            // Ініціалізувати змінну numerator
            // Ініціалізувати змінну denominator
            // Ініціалізувати змінну whole
        }
        // Оголошення параметризованого конструктора
        public Fraction(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
            whole = 0;
            // Ініціалізувати змінну numerator
            // Ініціалізувати змінну denominator
            // Ініціалізувати змінну whole
        }
        // Оголошення параметризованого конструктора
        public Fraction(int whole, int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
            this.whole = whole;
            // Ініціалізувати змінну numerator
            // Ініціалізувати змінну denominator
            // Ініціалізувати змінну whole
        }

        public void ReduceFraction()
        {
            int nod = 1;
            int m = numerator;
            int n = denominator;

            m = Convert.ToInt32(m);
            n = Convert.ToInt32(n);

            while (m != 0 && n != 0)
            {
                if (m > n)
                {
                    m = m % n;
                }
                else
                {
                    n = n % m;
                }
            }


            nod = n + m;

            if(numerator == denominator)
            {
                whole = 1;
                numerator = 0;
                denominator = 1;
            }
            else
            {
                numerator = numerator / nod;
                denominator = denominator / nod;
            }

           

        }
        
    // Оголошення методу для перетворення дробу в неправильну форму
        public void MakeImproperFraction()
        {
            if (whole != 0)
            {
                numerator = numerator + whole * denominator ;
                whole = 0;

            }
        }



        public void MakeProperFraction()
        {
            // Якщо дріб представлений у неправильній формі

            if (numerator > denominator )
            {

                whole = numerator / denominator;
                numerator = numerator % denominator;
             
            }

            ReduceFraction();
            // Викликати метод для скорочення дробу ReduceFraction()
        }

        //Оголошення перевантаження оператора +
        public static Fraction operator +(Fraction x, Fraction y)
        {
            Fraction rez = new Fraction();

            // Оголосити змінну rez, типу даних Fraction,
            // ініціалізувати rez конструктором за замовчуванням

            x.MakeImproperFraction();
            y.MakeImproperFraction();

            // Викликати для x метод перетворення дробу в неправильну форму
            // Викликати для y метод перетворення дробу в неправильну форму

            if (x.denominator == y.denominator)
            {
                rez.numerator = x.numerator + y.numerator;
                rez.denominator = x.denominator;
            }

            else
            {
                rez.numerator = x.numerator * y.denominator + y.numerator * x.denominator;
                rez.denominator = x.denominator * y.denominator;

            }

            rez.MakeProperFraction();
            return rez;

        }

        // Оголошення перевантаження оператора -
        public static Fraction operator -(Fraction x, Fraction y)
        {
            x.MakeImproperFraction();
            y.MakeImproperFraction();
            Fraction rez = new Fraction();
            rez.numerator = x.numerator * y.denominator - y.numerator * x.denominator;
            rez.denominator = y.denominator * x.denominator;

            int m = x.numerator * y.denominator;
            int n = y.numerator * x.denominator;
            if (m < n)
            {
                rez = new Fraction(n - m, x.denominator * y.denominator);
                rez.MakeProperFraction();
                rez.whole *= -1;
                if (rez.whole == 0) rez.numerator *= -1;
                return rez;
            }

            rez.MakeProperFraction();

            
            return rez;
        }



        // Оголошення перевантаження оператора *
        public static Fraction operator * (Fraction x, Fraction y)
        {
            Fraction rez = new Fraction();
            
            x.MakeImproperFraction ();
            y.MakeImproperFraction ();

            rez.numerator = x.numerator * y.numerator;
            rez.denominator = x.denominator * y.denominator;

            rez.MakeProperFraction();
            return rez;

            // Оголосити змінну rez, типу даних Fraction,
            // ініціалізувати rez конструктором за замовчуванням
            // Викликати для x метод перетворення дробу в неправильну форму
            // Викликати для y метод перетворення дробу в неправильну форму
            // Визначити для rez значення чисельника
            // Визначити для rez значення знаменника
            // Викликати для rez метод перетворення дробу в правильну форму
            // Повернути змінну rez
        }

        // Оголошення перевантаження оператора /
        public static Fraction operator / (Fraction x, Fraction y)
        {
            Fraction rez = new Fraction();

            x.MakeImproperFraction();
            y.MakeImproperFraction();

            rez.numerator = x.numerator * y.denominator;
            rez.denominator = x.denominator * y.numerator;

            rez.MakeProperFraction();
            return rez;

            // Оголосити змінну rez, типу даних Fraction,
            // ініціалізувати rez конструктором за замовчуванням
            // Викликати для x метод перетворення дробу в неправильну форму
            // Викликати для y метод перетворення дробу в неправильну форму
            // Визначити для rez значення чисельника
            // Визначити для rez значення знаменника
            // Викликати для rez метод перетворення дробу в правильну форму
            // Повернути змінну rez
        }
        // Оголошення перевантаження оператора перетворення з типу Fraction в string
        public static implicit operator string(Fraction x)
        {
            // Якщо ціла частина та чисельник дробу дорівнюють нулю 
            if (x.whole == 0 & x.numerator == 0 )
            {
                string str = x.whole.ToString();
                return str;
                // Повернути змінну типу даних string, відповідну змінній x
            }
            // Якщо чисельник дробу дорівнює нулю
            if (x.numerator == 0)
            {
                String str = x.whole.ToString();
                return str;
                // Повернути змінну типу даних string, відповідну змінній x
            }
            // Якщо ціла частина дробу дорівнює нулю
            if (x.whole == 0)
            {
                String str =  x.numerator + " / " + x.denominator;
                return str;
                // Повернути змінну типу даних string, відповідну змінній x
            }

            else
            {
                String str = x.whole + " / " + x.numerator + " / " + x.denominator;
                return str;
            }
            
            // Якщо жодна з попередніх умов не виконується,
            // повернути змінну типу даних string, відповідну змінній x
        }

        // Оголошення перевантаження оператора перетворення з типу string в Fraction
        public static implicit operator Fraction(string x)
        {
            Fraction rez = new Fraction();

            string[] right = x.Split('/');
            switch (right.Length)
            {

                case 1:
                    rez.whole = Convert.ToInt32((string)right[0]);
                    break;
                case 2:
                    rez.numerator = Convert.ToInt32((string)right[0]);
                    rez.denominator = Convert.ToInt32((string)right[1]);
                    break;
                case 3:

                    rez.whole = Convert.ToInt32((string)right[0]);
                    rez.numerator = Convert.ToInt32((string)right[1]);
                    rez.denominator = Convert.ToInt32((string)right[2]);
                    break;
            }
            // Повернути змінну rez
            return rez;
        }

    }
}
