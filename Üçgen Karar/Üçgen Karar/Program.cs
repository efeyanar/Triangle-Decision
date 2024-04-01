int a=0, b=0, c=0;

tepe:
try
{
    Console.Write("Üçgenin Birinci Kenarını Giriniz : ");
    a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("");
    if (a <= 0)
    {
        Console.WriteLine("Kenar Uzunluğu 0 ve 0'dan Küçük Olamaz.");
        Console.WriteLine("");
        goto tepe;
    }
}
catch (Exception ex)
{
    Console.WriteLine("");
    Console.WriteLine("Bilgilerinizi Doğru Girdiğinizden Emin Olunuz.");
    Console.WriteLine("");

    goto tepe;
}


tepeiki:
try
{

    Console.Write("Üçgenin İkinci Kenarını Giriniz : ");
    b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("");
    if (b <= 0)
    {
        Console.WriteLine("Kenar Uzunluğu 0 ve 0'dan Küçük Olamaz.");
        Console.WriteLine("");
        goto tepeiki;
    }
}
catch (Exception ex)
{
    Console.WriteLine("");
    Console.WriteLine("Bilgilerinizi Doğru Girdiğinizden Emin Olunuz.");
    Console.WriteLine("");

    goto tepeiki;
}


tepeuc:
try
{

    Console.Write("Üçgenin Üçüncü Kenarını Giriniz : ");
    c = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("");
    if (c <= 0)
    {
        Console.WriteLine("Kenar Uzunluğu 0 ve 0'dan Küçük Olamaz.");
        Console.WriteLine("");
        goto tepeuc;
    }
}
catch (Exception ex)
{
    Console.WriteLine("");
    Console.WriteLine("Bilgilerinizi Doğru Girdiğinizden Emin Olunuz.");
    Console.WriteLine("");

    goto tepeuc;
}
    
//
    if (a == b)
    {
        if (a == c)
        {
            Console.WriteLine("Bu Üçgen Eşkenar Üçgendir.");
        }
        else if (a != c)
        {
            Console.WriteLine("Bu Üçgen İkizkenar Üçgendir.");
        }
    }
    else if (a != b)
    {
        if (a == c)
        {
            Console.WriteLine("Bu Üçgen İkizkenar Üçgendir.");
        }
        else if (b == c)
        {
            Console.WriteLine("Bu Üçgen İkizkenar Üçgendir.");
        }
        else if (a != c && b != c)
        {
            Console.WriteLine("Bu Üçgen Çeşitkenar Üçgendir.");
        }
    }


Console.ReadLine();