//using System;

//class Rectangle
//{
//    private double a;
//    private double b;
//    private string color;

//    public Rectangle(double a, double b, string color)
//    {
//        this.a = a;
//        this.b = b;
//        this.color = color;
//    }

//    // Індексатор
//    public object this[int index]
//    {
//        get
//        {
//            return index switch
//            {
//                0 => a,
//                1 => b,
//                2 => color,
//                _ => "Помилка: Неправильний індекс!"
//            };
//        }
//        set
//        {
//            switch (index)
//            {
//                case 0:
//                    if (value is double newA) a = newA;
//                    break;
//                case 1:
//                    if (value is double newB) b = newB;
//                    break;
//                case 2:
//                    if (value is string newColor) color = newColor;
//                    break;
//                default:
//                    Console.WriteLine("Помилка: Неправильний індекс!");
//                    break;
//            }
//        }
//    }

//    // Перевантаження ++ та --
//    public static Rectangle operator ++(Rectangle rect)
//    {
//        rect.a++;
//        rect.b++;
//        return rect;
//    }

//    public static Rectangle operator --(Rectangle rect)
//    {
//        rect.a--;
//        rect.b--;
//        return rect;
//    }

//    // Перевантаження true і false
//    public static bool operator true(Rectangle rect) => rect.a == rect.b;
//    public static bool operator false(Rectangle rect) => rect.a != rect.b;

//    // Перевантаження операції *
//    public static Rectangle operator *(Rectangle rect, double scalar)
//    {
//        return new Rectangle(rect.a * scalar, rect.b * scalar, rect.color);
//    }

//    // Перетворення Rectangle → string
//    public override string ToString()
//    {
//        return $"{a},{b},{color}";
//    }

//    // Перетворення string → Rectangle
//    public static Rectangle Parse(string str)
//    {
//        var parts = str.Split(',');
//        if (parts.Length == 3 &&
//            double.TryParse(parts[0], out double a) &&
//            double.TryParse(parts[1], out double b))
//        {
//            return new Rectangle(a, b, parts[2]);
//        }
//        throw new FormatException("Невірний формат рядка");
//    }

//    // Метод для виводу інформації
//    public void Show()
//    {
//        Console.WriteLine($"Прямокутник: {a} x {b}, колір: {color}");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Rectangle rect = new Rectangle(5, 10, "Червоний");
//        rect.Show();

//        // Тестування індексатора
//        Console.WriteLine(rect[0]); // a
//        Console.WriteLine(rect[1]); // b
//        Console.WriteLine(rect[2]); // колір
//        Console.WriteLine(rect[3]); // Помилка

//        // Зміна значень через індексатор
//        rect[0] = 7;
//        rect[1] = 7;
//        rect.Show();

//        // Перевантаження ++ і --
//        rect++;
//        rect.Show();
//        rect--;
//        rect.Show();

//        // Перевірка true / false
//        if (rect)
//            Console.WriteLine("Це квадрат");
//        else
//            Console.WriteLine("Це не квадрат");

//        // Перевантаження *
//        Rectangle rect2 = rect * 2;
//        rect2.Show();

//        // Перетворення в рядок і назад
//        string rectStr = rect.ToString();
//        Console.WriteLine("Рядок: " + rectStr);

//        Rectangle rect3 = Rectangle.Parse(rectStr);
//        rect3.Show();

//        // Запобігання закриттю консолі
//        Console.ReadKey();
//    }
//}

















//using System;

//class VectorShort
//{
//    protected short[] ShortArray;
//    protected uint n;
//    protected uint codeError;
//    protected static uint num_v = 0;

//    // Конструктор без параметрів
//    public VectorShort()
//    {
//        n = 1;
//        ShortArray = new short[n];
//        ShortArray[0] = 0;
//        num_v++;
//    }

//    // Конструктор з одним параметром (розмір вектора)
//    public VectorShort(uint size)
//    {
//        n = size;
//        ShortArray = new short[n];
//        num_v++;
//    }

//    // Конструктор з двома параметрами (розмір і значення ініціалізації)
//    public VectorShort(uint size, short value)
//    {
//        n = size;
//        ShortArray = new short[n];
//        for (int i = 0; i < n; i++)
//            ShortArray[i] = value;
//        num_v++;
//    }

//    // Деструктор
//    ~VectorShort()
//    {
//        Console.WriteLine("VectorShort object is being deleted");
//    }

//    // Метод для введення елементів вектора
//    public void InputElements()
//    {
//        for (int i = 0; i < n; i++)
//        {
//            Console.Write($"Enter element [{i}]: ");
//            ShortArray[i] = short.Parse(Console.ReadLine());
//        }
//    }

//    // Метод для виведення елементів вектора
//    public void PrintElements()
//    {
//        Console.WriteLine("Vector elements: " + string.Join(", ", ShortArray));
//    }

//    // Властивість для отримання розміру вектора
//    public uint Size => n;

//    // Властивість для роботи з codeError
//    public uint CodeError
//    {
//        get { return codeError; }
//        set { codeError = value; }
//    }

//    // Індексатор
//    public short this[int index]
//    {
//        get
//        {
//            if (index < 0 || index >= n)
//            {
//                codeError = 10;
//                return 0;
//            }
//            return ShortArray[index];
//        }
//        set
//        {
//            if (index < 0 || index >= n)
//                codeError = 10;
//            else
//                ShortArray[index] = value;
//        }
//    }

//    // Перевантаження оператора ++
//    public static VectorShort operator ++(VectorShort v)
//    {
//        for (int i = 0; i < v.n; i++)
//            v.ShortArray[i]++;
//        return v;
//    }

//    // Перевантаження оператора --
//    public static VectorShort operator --(VectorShort v)
//    {
//        for (int i = 0; i < v.n; i++)
//            v.ShortArray[i]--;
//        return v;
//    }

//    // Перевантаження оператора ! (логічне заперечення)
//    public static bool operator !(VectorShort v)
//    {
//        return v.n == 0;
//    }

//    // Перевантаження оператора ~ (побітове заперечення)
//    public static VectorShort operator ~(VectorShort v)
//    {
//        VectorShort result = new VectorShort(v.n);
//        for (int i = 0; i < v.n; i++)
//            result.ShortArray[i] = (short)~v.ShortArray[i];
//        return result;
//    }

//    // Перевантаження операторів +, -, *, /
//    public static VectorShort operator +(VectorShort v1, VectorShort v2)
//    {
//        uint maxSize = Math.Max(v1.n, v2.n);
//        VectorShort result = new VectorShort(maxSize);
//        for (int i = 0; i < maxSize; i++)
//            result.ShortArray[i] = (short)(v1[i] + v2[i]);
//        return result;
//    }

//    public static VectorShort operator +(VectorShort v, short scalar)
//    {
//        VectorShort result = new VectorShort(v.n);
//        for (int i = 0; i < v.n; i++)
//            result.ShortArray[i] = (short)(v.ShortArray[i] + scalar);
//        return result;
//    }

//    // Операція порівняння ==
//    public static bool operator ==(VectorShort v1, VectorShort v2)
//    {
//        if (v1.n != v2.n) return false;
//        for (int i = 0; i < v1.n; i++)
//            if (v1.ShortArray[i] != v2.ShortArray[i])
//                return false;
//        return true;
//    }

//    public static bool operator !=(VectorShort v1, VectorShort v2)
//    {
//        return !(v1 == v2);
//    }

//    // Метод для отримання кількості векторів
//    public static uint GetVectorCount()
//    {
//        return num_v;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        VectorShort v1 = new VectorShort(3, 5);
//        VectorShort v2 = new VectorShort(3, 2);

//        Console.WriteLine("Initial vectors:");
//        v1.PrintElements();
//        v2.PrintElements();

//        VectorShort sum = v1 + v2;
//        Console.WriteLine("Sum of vectors:");
//        sum.PrintElements();
//        Console.ReadKey();
//    }
//}














using System;

class MatrixShort
{
    protected uint[,] ShortArray;
    protected int n, m;
    protected int codeError;
    private static int num_m = 0;

    public MatrixShort()
    {
        n = 1; m = 1;
        ShortArray = new uint[n, m];
        ShortArray[0, 0] = 0;
        num_m++;
    }

    public MatrixShort(int rows, int cols)
    {
        n = rows; m = cols;
        ShortArray = new uint[n, m];
        num_m++;
    }

    public MatrixShort(int rows, int cols, uint initValue)
    {
        n = rows; m = cols;
        ShortArray = new uint[n, m];
        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
                ShortArray[i, j] = initValue;
        num_m++;
    }

    ~MatrixShort()
    {
        Console.WriteLine("Matrix destroyed");
    }

    public void InputMatrix()
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write($"Element [{i},{j}]: ");
                ShortArray[i, j] = uint.Parse(Console.ReadLine());
            }
        }
    }

    public void PrintMatrix()
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(ShortArray[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    public static int MatrixCount()
    {
        return num_m;
    }

    public int Rows => n;
    public int Cols => m;

    public int CodeError
    {
        get { return codeError; }
        set { codeError = value; }
    }

    public uint this[int i, int j]
    {
        get
        {
            if (i >= 0 && i < n && j >= 0 && j < m)
                return ShortArray[i, j];
            codeError = -1;
            return 0;
        }
        set
        {
            if (i >= 0 && i < n && j >= 0 && j < m)
                ShortArray[i, j] = value;
            else
                codeError = -1;
        }
    }

    public uint this[int k]
    {
        get
        {
            int i = k / m;
            int j = k % m;
            if (i < n && j < m)
                return ShortArray[i, j];
            codeError = -1;
            return 0;
        }
        set
        {
            int i = k / m;
            int j = k % m;
            if (i < n && j < m)
                ShortArray[i, j] = value;
            else
                codeError = -1;
        }
    }

    public static MatrixShort operator ++(MatrixShort matrix)
    {
        for (int i = 0; i < matrix.n; i++)
            for (int j = 0; j < matrix.m; j++)
                matrix.ShortArray[i, j]++;
        return matrix;
    }

    public static MatrixShort operator --(MatrixShort matrix)
    {
        for (int i = 0; i < matrix.n; i++)
            for (int j = 0; j < matrix.m; j++)
                matrix.ShortArray[i, j]--;
        return matrix;
    }

    public static bool operator true(MatrixShort matrix)
    {
        return matrix.n != 0 && matrix.m != 0 && matrix.ShortArray.Length != 0;
    }

    public static bool operator false(MatrixShort matrix)
    {
        return matrix.n == 0 || matrix.m == 0 || matrix.ShortArray.Length == 0;
    }

    public static bool operator !(MatrixShort matrix)
    {
        return matrix.n == 0 || matrix.m == 0;
    }

    public static MatrixShort operator +(MatrixShort a, MatrixShort b)
    {
        if (a.n != b.n || a.m != b.m)
            return a;
        MatrixShort result = new MatrixShort(a.n, a.m);
        for (int i = 0; i < a.n; i++)
            for (int j = 0; j < a.m; j++)
                result.ShortArray[i, j] = a.ShortArray[i, j] + b.ShortArray[i, j];
        return result;
    }

    public static MatrixShort operator +(MatrixShort matrix, short scalar)
    {
        MatrixShort result = new MatrixShort(matrix.n, matrix.m);
        for (int i = 0; i < matrix.n; i++)
            for (int j = 0; j < matrix.m; j++)
                result.ShortArray[i, j] = (uint)(matrix.ShortArray[i, j] + scalar);
        return result;
    }
}

class Program
{
    static void Main()
    {
        MatrixShort mat1 = new MatrixShort(2, 2, 5);
        MatrixShort mat2 = new MatrixShort(2, 2, 3);
        MatrixShort mat3 = mat1 + mat2;

        Console.WriteLine("Matrix 1:");
        mat1.PrintMatrix();
        Console.WriteLine("Matrix 2:");
        mat2.PrintMatrix();
        Console.WriteLine("Matrix 3 (sum of Matrix 1 and 2):");
        mat3.PrintMatrix();
        Console.ReadKey();
    }
}
