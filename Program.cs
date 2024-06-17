    //1. Doira yuzi va aylana uzunligini hisoblash
    Console.Write("Enter Radius: ");
    double rad = Convert.ToDouble(Console.ReadLine());
    double area = Math.PI * Math.Pow(rad,2);
    double lenght = 2*Math.PI*rad;
    Console.WriteLine($"Area of circle is: {area} and lenght: {lenght}");
    //2. Valyuta konvertri
    Console.Write("Enter the $: ");
    double dollar = Convert.ToDouble(Console.ReadLine());
    double suwm = dollar*12400;
    System.Console.WriteLine($"Your money {suwm} suwm");
    //3. Yoshni hisoblash
    Console.Write("Iltimos, tug'ilgan yilingizni kiriting: ");
    int tugilganYil = Convert.ToInt32(Console.ReadLine());
    int hozirgiYil = DateTime.Now.Year;
    int yoshiYillarda = hozirgiYil - tugilganYil;
    int yoshiKunlarda = yoshiYillarda * 365;
    Console.WriteLine("Sizning yoshingiz kunlarda: " + yoshiKunlarda);
    Console.ReadKey();