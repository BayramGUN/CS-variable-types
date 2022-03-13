using System;

namespace CS_odev1_degiskenler
{
    class Program
    {
        public static void Main()
        {
            //tam sayılar
            int intMax = int.MaxValue, intMin = int.MinValue; //bellekte 4 bytelık integer veri tutar. (-2.147.483.648 - 2.147.483.647 arasında) 
            Int16 i16Max = Int16.MaxValue, i16Min = Int16.MinValue; //bellekte 2 bytelık integer veri tutar. (-32768 - 32767 arasında)
            Int32 i32Max = Int32.MaxValue, i32Min = Int32.MinValue; //bellekte 4 bytelık integer veri tutar. (-2147483648 - 2147483647 arasında)
            Int64 i64Max = Int64.MaxValue, i64Min = Int64.MinValue; //bellekte 8 bytelık integer veri tutar. (-9223372036854775808 - 9223372036854775807 arasında)
            uint uintMax = uint.MaxValue, uintMin = uint.MinValue; //bellekte 4 bytelık integer veri tutar. (0 - 429496729 arasında)
            long lMax = long.MaxValue, lMin = long.MinValue; //bellekte 8 bytelık integer veri tutar. (-9223372036854775808 - 9223372036854775807 arasında -Int64 ile aynı-)
            ulong ulMin = ulong.MinValue, ulMax = ulong.MaxValue; //bellekte 4 bytelık integer veri tutar. (0 - 18446744073709551615 arasında)
            byte b = byte.MaxValue, bz = byte.MinValue; //bellekte 1 bytelık integer veri tutar. (0 - 255 arasında) 
            sbyte sbn = sbyte.MinValue, sb = sbyte.MaxValue; // bellekte 1 bytlık integer veri tutar. (-128 - 127 arasında)
            short kisaMax = short.MaxValue, kisaMin = short.MinValue; //bellekte 2 bytelık integer veri tutar. (-32768 - 32767 arasında)
            ushort isaretsizKisaMax = ushort.MaxValue, isaretsizKisaMin = ushort.MinValue; // bellekte 2 bytelık integer veri tutar. (0 - 65535 arasında)

            //reel sayılar
            float fMin = float.MinValue, fMax = float.MaxValue; //bellekte 4 bytelık float veri tutar. (-3.4028235E+38 - 3.4028235E+38 arasında)
            double dMin = double.MinValue, dMax = double.MaxValue; //bellekte 8 bytelık double veri tutar. (-1.7976931348623157E+308 - 1.7976931348623157E+308 arasında)
            decimal decMin = Decimal.MinValue, decMax = Decimal.MaxValue;//bellekte 8 bytelık decimal veri tutar. (-79228162514264337593543950335 - 79228162514264337593543950335 arasında)


            //karakter verileri
            char c = ' ', goz = ':', agiz = ')'; //bellekte 2 bytelık karakter veri tutar. Bir karakterlik ASCII değer alır. 
            string Degisken = " ";
            string degisken = string.Empty, merhaba = "Merhaba"; //RAMin izin verdiği kadar veri tutabilir. Bir çok karakterle oluşabilen string değerler alır.

            //mantıksal veriler
            bool booleanT = true, booleanF = false;//bellekte 1 bitlik veri tutarlar. true veya false değerler alırlar.

            //Tarih/Saat verileri
            DateTime dateNow = DateTime.Now, dateToday = DateTime.Today, dateUTC = DateTime.UtcNow; 

            //Nesneler
            object objeChar = 'c', objeString = "String Obje", objeInt = 25, objeFloat = 15.22; //her türden veriyi tutabilirler. her değişken tipi aslında bir objedir.

            if(Degisken == "") //"Degisken" degeri whitespace olduğu için bu blok çalışmaz.
            {
                Console.WriteLine("Bir gariplik var gibi duruyor!");
            } else 
                Console.WriteLine(merhaba + c + goz + agiz + "\n"); //karakter bastırırken "+" işareti ile değişkenleri yanyana yazmak mümkündür.


            Console.WriteLine("DateTime verileri: \n" + "DateTime.Now: " +dateNow + "\nDateTime.Today: " + dateToday + "\nDateTime.UtcNow: " + dateUTC);

            Console.WriteLine("\nSayisal veriler:" + degisken + "\nbyte verileri:\t" + b + " - " + bz + "\nint verileri: \t" 
                                + intMin + " - " + intMax + "\nshort verileri: \t" + kisaMin 
                                + " - " + kisaMax + "\nushort verileri: \t" + isaretsizKisaMin 
                                + " - " + isaretsizKisaMax + "\nsbyte  verileri: \t" + sbn + " - " + sb
                                + "\nInt16 verileri: \t" + i16Min + " - " + i16Max + "\nInt32 verileri: \t"
                                + i32Min + " - " + i32Max + "\nInt64 verileri: \t" + i64Min + " - "
                                +i64Max + "\nuint verileri: \t" + uintMin + " - " + uintMax + "\nfloat verileri: \t"
                                + fMin + " - " + fMax + "\nlong  verileri: \t" + lMin + " - " + lMax
                                + "\nulong  verileri: \t" +ulMin + " - " + ulMax + "\ndouble  verileri: \t" + dMin + " - " + dMax
                                + "\ndecimal  verileri: \t" + decMin + " - " + decMax + "\nbool verileri: \t" + booleanT + " - " + booleanF);

            Console.WriteLine("\nobject verileri: \n" + objeChar + "\n" + objeString + "\n"
                                + objeInt + "\n" + objeFloat);
            Console.WriteLine();
            //değişkenlere sayısal operatörler ile atama.
            int one = 12, two = 32;
            int three = one * two; //"three" değişkenine, "one" ve "two" değişkenlerinin çarpımı atanmakta.
            Console.WriteLine("int three = one * two taniminin degeri: " + three);
            
            //bool farklı değer atama yöntemi
            bool boolDif = 100 > 200; //false değeri atama.
            bool boolDif2 = 100 < 200; //true değeri atama.
            Console.WriteLine();
            if(boolDif)
            {
                Console.WriteLine("false deger atanmis\n");
            }else 
                Console.WriteLine("false deger atanamamis\n");
            if(boolDif2)
            {
                Console.WriteLine("true deger atanmis\n");
            }else 
                Console.WriteLine("true deger atanamamis\n");

            //Değişken dönüşümleri
            string sa = "20";
            int year = 22;
            string newYear = sa +  Degisken + year.ToString();
            Console.WriteLine(newYear);//2022 değerini bastırır.
            Console.WriteLine();
            string number = "321";
            int sayi = 322;
            int sum = sayi + Convert.ToInt32(number);
            int sumPar = sayi + int.Parse(number);
            Console.WriteLine(sum + "\n" + sumPar); //alt alta 643 değerini bastırır.
            Console.WriteLine();
            //DateTime to string dönüşümü
            string date = dateNow.ToString("yyyy");//yıl
            Console.WriteLine(merhaba + Degisken + date);
            Console.WriteLine();
            string hour = dateNow.ToString("HH:mm");//saat 
            Console.WriteLine("Saat " + hour);
        }
    }
}