using System;
using System.Threading;
using System.Threading.Channels;
using System.Globalization;
void bla()
{
    Console.WriteLine();
    Console.WriteLine("------------------------------------------------------------------");
    Console.WriteLine();
}
void menu(string[] arr1, double[] arr2)
{
    for(int i = 0; i < arr1.Length; i++)
    {
        bla();
        Console.WriteLine("{0}\t{1}\t{2}FM",(i + 1),arr1[i],arr2[i]);
    }
    bla();
}
void invalid()
{
    Console.WriteLine("Invalid Process! Please enter again!");
}
void ClearLine()
{
    Console.SetCursorPosition(0, Console.CursorTop);
    Console.Write(new string(' ', Console.WindowWidth));
    Console.SetCursorPosition(0, Console.CursorTop - 1);
}
void timer(int sec,int min,int hour)
{
    int count = 1;
    do
    {
        if ((sec >= 0 && sec < 60) && (min >= 0 && min < 60) && (hour >= 0 && hour < 24))
        {
            while (true)
            {
                if (sec == 60)
                {
                    min++;
                    sec = 0;
                }
                if (min == 60)
                {
                    hour++;
                    sec = 0;
                    min = 0;
                }
                if (hour == 24)
                {
                    count = 0;
                    break;
                }

                if (sec < 10 && min < 10 && hour < 10)
                {
                    Console.WriteLine("0" + hour + ":" + "0" + min + ":" + "0" + sec);
                }
                else if (sec >= 10 && min < 10 && hour < 10)
                {
                    Console.WriteLine("0" + hour + ":" + "0" + min + ":" + sec);
                }
                else if (sec < 10 && min >= 10 && hour < 10)
                {
                    Console.WriteLine("0" + hour + ":" + min + ":" + "0" + sec);
                }
                else if (sec >= 10 && min >= 10 && hour < 10)
                {
                    Console.WriteLine("0" + hour + ":" + min + ":" + sec);
                }
                else if (sec < 10 && min >= 10 && hour >= 10 && hour < 24)
                {
                    Console.WriteLine( hour + ":" + min + ":" + "0" + sec);
                }
                else if (sec < 10 && min <= 10 && hour >= 10 && hour < 24)
                {
                    Console.WriteLine( hour + ":" + "0" + min + ":" + "0" + sec);
                }
                else if (sec >= 10 && min <= 10 && hour >= 10 && hour < 24)
                {
                    Console.WriteLine( hour + ":" + "0" + min + ":" + sec);
                }
                else
                {
                    Console.WriteLine(hour + ":" + min + ":" + sec);
                }
               Thread.Sleep(1000);
                sec++;
                ClearLine();
                
            }
        }
        
    } while (count != 0);
}
char co;
string[] chnames = {"Delta FM", "Ntv Spor", "Radyo İstanbul", "TRT Radyo 3", "Lalegül FM", "İstanbul FM", "Burç FM", "Joy Türk", "Alem FM", "Yaşam Radyo", "Müjde FM", "Show Radyo", "Radyo Viva", "Radyo Turkuvaz", "Haber Türk", "2000 FM", "Süper FM", "Radyo Alaturka", "Radio Time", "TRT Radyo 2", "Radyo 24", "İstanbulun Sesi", "Kral FM", "Lig Radyo", "CNN Türk", "Pop Türk", "Kanaltürk Radyo", "TGRT FM", "Karadenizin Sesi", "Dünya Radyo", "Radio FG", "Medya FM", "Polis Radyosu", "Radyo Ekin", "Rock FM", "Radyo 5", "Açık Radyo", "Özgür Radyo", "Slow Türk", "TRT Radyo 1", "Lokum TR", "Lounge O2", "Radyo Eksen", "Cem Radyo", "Yön Radyo", "Radyo Moda", "Küpe FM", "Metro FM", "Radyo Feza", "Radyo Tatlıses", "Meltem Radyo", "Kral Türk", "Karadeniz FM", "Best FM", "Radyo Klas", "Star FM", "Karmatürk", "Pal FM", "Virgin Radio", "Melodi FM", "Power Türk", "Power FM", "Power XL", "Radyo Fenomen", "Joy FM", "İlaç Radyo", "Radyo N101", "Radyo 15" , "Radyo Festival", "TRT Nağme", "Radyo Vatan", "Lounge 102", "Seyr FM", "Number One FM", "Radyo Planet", "NTV Radyo", "Meteor FM", "Özel FM", "TRT 4", "Radio Light", "Radio Dinamo", "Radyo D", "Radyo Pink", "Bizim Radyo", "Radyo 7", "Karma Love", "Moral FM", "Marmara FM", "Radyo Mega", "Radyo 1", "Radyo HitMix", "Pal Station", "Radio Mydonose", "Radyo Mavi", "Doğuş FM", "Vizyon Türk", "S.Haber", "Radyo Barış", "Radyo Spor", "Radio Voyage", "Akra FM", "Radyo Özlem", "Radyo Dolunay" };
double[] frnums = { 87.5,87.7,88.0,88.2,88.4,88.6,88.8,89.0,89.2,89.4,89.6,89.8,90.0,90.2,90.4,90.6,90.8,91.0,91.2,91.4,91.6,91.8,92.0,92.3,92.5,92.7,92.9,93.2,93.3,93.5,93.7,93.9,94.1,94.3,94.5,94.7,94.9,95.1,95.3,95.6,95.8,96.0,96.2,96.4,96.6,96.8,97.0,97.2,97.4,97.6,97.8,98.0,98.2,98.4,98.6,98.8,99.0,99.2,99.4,99.6,99.8,100.0,100.2,100.4,100.6,100.8,101.0,101.2,101.4,101.6,101.8,102.0,102.2,102.4,102.6,102.8,103.0,103.2,103.4,103.6,103.8,104.0,104.2,104.4,104.6,104.8,105.0,105.2,105.4,105.6,105.8,106.0,106.2,106.4,106.5,106.6,106.8,107.0,107.2,107.4,107.6,107.8,108.0 };
string[] mus = { "Joy Türk FM", "Süper FM ", "Power Türk FM", "Kral Pop", "Damar FM", "Radyo K", "Radyo Eksen", "Radyo Fenomen", "Metro FM", "Virgin Radio", "Pal FM", "Number One FM", "Radyo Damar", "Radyo Mydonose", "Radyo Voyage" };
double[] musnums = { 89.0 , 90.8 , 91.2 , 92.0 , 93.4 , 94.9 , 96.2 , 97.0 , 97.2 , 97.7 , 99.2 , 102.4 , 105.9 , 106.5 , 107.4 };
string[] loc = { "İstanbul FM", "Alem FM", "Show Radyo", "Süper FM", "İstanbulun Sesi FM", "Radyo Viva", "A Haber Radyo", "TGRT FM", "Radyo Turkuvaz", "Radyo Eksen", "Radyo Spor", "Radyo Moda", "Radyo Nefes", "Radyo Trafik", "Radyo Maksimum", "Radyo 7 ", "Dost Radyo", "Radyo Voyage" };
double[] locnums = { 88.6 , 89.2 , 89.6 , 90.8, 91.8, 92.3 , 92.6 , 93.2 , 94.2 , 96.2 , 96.6 , 96.8 , 98.0 , 102.2 , 103.7 ,104.6, 106.0 , 107.4 };
string[] news = { "A Haber Radyo", "NTV Radyo", "CNN Türk Radyo", "Radyo Habertürk", "Medya FM", "TRT Haber Radyo", "Radyo İstanbul", "TGRT Haber Radyo" };
double[] newsnums = { 90.2, 92.4, 96.0 , 96.2 , 102.7 , 105.6 , 106.0 , 106.3 };
string[] options = { "All Channels", "Music", "Local", "News" };
string[] commands = { "Finding Radio Channel By Frequncy Number", "Finding Radio Channel By Channel Name","Listening The Radio"};
int sec=0, min=0, hour=0,ch,ch1,cm;
bla();
Console.WriteLine("Welcome To MEG Radio");
do
{
    bla();
    Console.WriteLine("Commands :");
    bla();
    for (int i = 0; i < commands.Length; i++)
    {
        bla();
        Console.WriteLine((i + 1) + " - " + commands[i]);
    }
    bla();
    Console.Write("Please choose your command : ");
    cm = Convert.ToInt32(Console.ReadLine());
    bla();
    if (cm == 1)
    {
        int tr = 0;
        double fre=0.0;
        Console.Write("Please enter the frequency number : ");
        fre  = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        if (fre >= 87.5 && fre <= 108.0)
        {
            for (int i = 0; i < frnums.Length; i++)
            {
                if (fre == frnums[i])
                {
                    tr = 1;
                    Console.WriteLine(chnames[i] + "       " + frnums[i]);
                    break;
                }
            }
            if (tr == 0)
            {
                invalid();
                Console.WriteLine("There is no channel with this frequency number!");
            }
        }
        else
        {
            invalid();
            Console.WriteLine("There is no channel with this name!");
        }
    }
    else if (cm == 2)
    {
        int tr = 0;
        string choice;
        Console.Write("Please enter the channel name : ");
        choice = Console.ReadLine();
        for (int i = 0; i < frnums.Length; i++)
        {
            if (choice == chnames[i])
            {
                tr = 1;
                Console.WriteLine(chnames[i] + "       " + frnums[i]);
                break;
            }
        }
        if (tr == 0)
        {
            invalid();
            Console.WriteLine("There is no channel with this name!");
        }
        
    }
    else if (cm == 3)
    {
        for (int i = 0; i < options.Length; i++)
        {
            bla();
            Console.WriteLine((i + 1) + " - " + options[i]);
        }
        bla();
        Console.Write("Please enter your option : ");
        ch = Convert.ToInt32(Console.ReadLine());
        if (ch == 1)
        {
            menu(chnames, frnums);
            Console.Write("Please enter your channel number : ");
            ch1 = Convert.ToInt32(Console.ReadLine());
            if (ch1 > 0 && ch <= chnames.Length)
            {
                Console.WriteLine("Listening...");
                bla();
                Console.WriteLine(chnames[ch1 - 1] + "       " + frnums[ch1 - 1]);
                timer(sec, min, hour);

            }
            else
            {
                invalid();
            }
        }
        else if (ch == 2)
        {
            menu(mus, musnums);
            Console.Write("Please enter your channel number : ");
            ch1 = Convert.ToInt32(Console.ReadLine());
            if (ch1 > 0 && ch <= mus.Length)
            {
                Console.WriteLine("Listening...");
                bla();
                Console.WriteLine(mus[ch1 - 1] + "       " + musnums[ch1 - 1]);
                timer(sec, min, hour);

            }
            else
            {
                invalid();
            }
        }
        else if (ch == 3)
        {
            menu(loc, locnums);
            Console.Write("Please enter your channel number : ");
            ch1 = Convert.ToInt32(Console.ReadLine());
            if (ch1 > 0 && ch <= loc.Length)
            {
                Console.WriteLine("Listening...");
                bla();
                Console.WriteLine(loc[ch1 - 1] + "       " + locnums[ch1 - 1]);
                timer(sec, min, hour);

            }
            else
            {
                invalid();
            }
        }
        else if (ch == 4)
        {
            menu(news, newsnums);
            Console.Write("Please enter your channel number : ");
            ch1 = Convert.ToInt32(Console.ReadLine());
            if (ch1 > 0 && ch <= news.Length)
            {
                Console.WriteLine("Listening...");
                bla();
                Console.WriteLine(news[ch1 - 1] + "       " + newsnums[ch1 - 1]);
                timer(sec, min, hour);

            }
        }
        else
        {
            invalid();
        }
    }
    else
    {
        invalid();
    }
    Console.Write("Do you want to close the radio : ");
        co = Convert.ToChar(Console.ReadLine()[0]);

    Console.WriteLine();
} while (co == 'N' || co == 'n');
Console.WriteLine("GoodBye!");