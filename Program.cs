using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARABA_OYUNU_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bmw bmw = new bmw();
            mercedes mercedes = new mercedes();

            Console.WriteLine("yarış başladı ilk 3 dakika da en çok hıza ulaşan,kazanır");

            bmw.Hız = 50;
            mercedes.Hız = 50;

            Console.WriteLine("bmw nin hızı" + bmw.Hız);
            Console.WriteLine("merdeces nin hızı" + mercedes.Hız);

            // 1- HAYVAN ÇITI
            // 2-ŞERİT SAYISI DÜŞTÜ
            // 3-YOL BOŞ
            // 4-ŞERİT SAYISI ARTIYOR

            // bmw için yap bunları

            Random random = new Random();
            int RANDOM1 = random.Next(1, 5);
            int RANDOM2 = random.Next(1, 5);
            int RANDOM3 = random.Next(1, 5);
            int RANDOM4 = random.Next(1, 5);
            int RANDOM5 = random.Next(1, 5);
            int RANDOM6 = random.Next(1, 5);











            Console.WriteLine("bmw nin 1 dakikalık süreci");
            switch (RANDOM1)
            {
                case 1:
                    Console.WriteLine("önünüze hayvan çıkıyor");
                    bmw.korna();
                    bmw.dörtlü();
                    Random rnd1 = new Random();
                    int frenkuvveti = rnd1.Next(20, 30);
                    if (bmw.Hız <= 30)
                    {

                    }
                    else
                    {
                        bmw.Fren(frenkuvveti);
                    }

                    Console.WriteLine("frene basıyorsunuz");
                    Console.WriteLine("güncel hızınız" + bmw.Hız);
                    break;
                case 2:
                    Console.WriteLine("şerit sayısı düşüyor");
                    Random rnd2 = new Random();
                    int yavaşlama2 = rnd2.Next(10, 30);
                    if (bmw.Hız <= 30)
                    {
                        bmw.Fren(10);
                    }
                    else
                    {
                        bmw.Fren(yavaşlama2);
                    }
                    bmw.Fren(yavaşlama2);
                    Console.WriteLine("yavaşlıyorsunuz,şerit sayısı azaldığı için");
                    Console.WriteLine("güncel hızınız" + bmw.Hız);
                    break;
                case 3:
                    Console.WriteLine("yol tamamen boş");
                    Random rnd3 = new Random();
                    int gazlama = rnd3.Next(50, 100);
                    bmw.Gaz(gazlama);
                    Console.WriteLine("hızlanıyorsunuz,yol boş");
                    Console.WriteLine("güncel hızınız" + bmw.Hız);
                    break;
                case 4:
                    Console.WriteLine("şerit sayısı artıyor");
                    Random rnd4 = new Random();
                    int gazlama2 = rnd4.Next(30, 50);
                    bmw.Gaz(gazlama2);
                    Console.WriteLine("hızlanıyorsunuz şerit sayısı arttı");
                    Console.WriteLine("güncel hızınız" + bmw.Hız);
                    break;
                default:
                    Console.WriteLine("yanlış bir değer seçtiniz");
                    break;







            }
            Console.WriteLine("mercedes in 1 dakikalık süreci");
            switch (RANDOM2)
            {
                case 1:
                    Console.WriteLine("önünüze hayvan çıkıyor");
                    bmw.korna();
                    bmw.dörtlü();
                    Random rnd1 = new Random();
                    int frenkuvveti = rnd1.Next(20, 30);

                    if (mercedes.Hız <= 30)
                    {
                        mercedes.Fren(10);
                    }
                    else
                    {
                        mercedes.Fren(frenkuvveti);
                    }
                    
                    Console.WriteLine("frene basıyorsunuz");
                    Console.WriteLine("güncel hızınız" + mercedes.Hız);
                    break;
                case 2:
                    Console.WriteLine("şerit sayısı düşüyor");
                    Random rnd2 = new Random();
                    int yavaşlama2 = rnd2.Next(10, 30);
                    if(mercedes.Hız <= 30)
                    {
                        mercedes.Fren(10);
                    }
                    else
                    {
                        mercedes.Fren(yavaşlama2);
                    }
                    
                    Console.WriteLine("yavaşlıyorsunuz,şerit sayısı azaldığı için");
                    Console.WriteLine("güncel hızınız" + mercedes.Hız);
                    break;
                case 3:
                    Console.WriteLine("yol tamamen boş");
                    Random rnd3 = new Random();
                    int gazlama = rnd3.Next(50, 100);
                    mercedes.Gaz(gazlama);
                    Console.WriteLine("hızlanıyorsunuz,yol boş");
                    Console.WriteLine("güncel hızınız" + mercedes.Hız);
                    break;
                case 4:
                    Console.WriteLine("şerit sayısı artıyor");
                    Random rnd4 = new Random();
                    int gazlama2 = rnd4.Next(30, 50);
                    mercedes.Gaz(gazlama2);
                    Console.WriteLine("hızlanıyorsunuz şerit sayısı arttı");
                    Console.WriteLine("güncel hızınız" + mercedes.Hız);
                    break;
                default:
                    Console.WriteLine("yanlış bir değer seçtiniz");
                    break;





            }
            Console.WriteLine("bmw nin 2 dakikalık süreci");
            switch (RANDOM3)
            {
                case 1:
                    Console.WriteLine("önünüze hayvan çıkıyor");
                    Random rnd1 = new Random();
                    int frenkuvveti = rnd1.Next(20, 30);
                    if (bmw.Hız <= 30)
                    {
                        bmw.Fren(10);
                    }
                    else
                    {
                        bmw.Fren(frenkuvveti);
                    }
                    bmw.Fren(frenkuvveti);
                    Console.WriteLine("frene basıyorsunuz");
                    Console.WriteLine("güncel hızınız" + bmw.Hız);
                    break;
                case 2:
                    Console.WriteLine("şerit sayısı düşüyor");
                    Random rnd2 = new Random();
                    int yavaşlama2 = rnd2.Next(10, 30);
                    if (bmw.Hız <= 30)
                    {
                        bmw.Fren(10);
                    }
                    else
                    {
                        bmw.Fren(yavaşlama2);
                    }
                    bmw.Fren(yavaşlama2);
                    Console.WriteLine("yavaşlıyorsunuz,şerit sayısı azaldığı için");
                    Console.WriteLine("güncel hızınız" + bmw.Hız);
                    break;
                case 3:
                    Console.WriteLine("yol tamamen boş");
                    Random rnd3 = new Random();
                    int gazlama = rnd3.Next(50, 100);
                    bmw.Gaz(gazlama);
                    Console.WriteLine("hızlanıyorsunuz,yol boş");
                    Console.WriteLine("güncel hızınız" + bmw.Hız);
                    break;
                case 4:
                    Console.WriteLine("şerit sayısı artıyor");
                    Random rnd4 = new Random();
                    int gazlama2 = rnd4.Next(50, 100);
                    bmw.Gaz(gazlama2);
                    Console.WriteLine("hızlanıyorsunuz şerit sayısı arttı");
                    Console.WriteLine("güncel hızınız" + bmw.Hız);
                    break;
                default:
                    Console.WriteLine("yanlış bir değer seçtiniz");
                    break;







            }
            Console.WriteLine("mercedes in 2 dakikalık süreci");
            switch (RANDOM4)
            {
                case 1:
                    Console.WriteLine("önünüze hayvan çıkıyor");
                    Random rnd1 = new Random();
                    int frenkuvveti = rnd1.Next(20, 30);

                    if(mercedes.Hız <= 30)
                    {
                        mercedes.Fren(10);
                    }
                    else
                    {
                        mercedes.Fren(frenkuvveti);
                    }
                    
                    Console.WriteLine("frene basıyorsunuz");
                    Console.WriteLine("güncel hızınız" + bmw.Hız);
                    break;
                case 2:
                    Console.WriteLine("şerit sayısı düşüyor");
                    Random rnd2 = new Random();
                    int yavaşlama2 = rnd2.Next(10, 30);
                    
                    if (mercedes.Hız <= 30)
                    {
                        mercedes.Fren(10);
                    }
                    else
                    {
                        mercedes.Fren(yavaşlama2);
                    }
                    
                    Console.WriteLine("yavaşlıyorsunuz,şerit sayısı azaldığı için");
                    Console.WriteLine("güncel hızınız" + bmw.Hız);
                    break;
                case 3:
                    Console.WriteLine("yol tamamen boş");
                    Random rnd3 = new Random();
                    int gazlama = rnd3.Next(50, 100);
                    mercedes.Gaz(gazlama);
                    Console.WriteLine("hızlanıyorsunuz,yol boş");
                    Console.WriteLine("güncel hızınız" + bmw.Hız);
                    break;
                case 4:
                    Console.WriteLine("şerit sayısı artıyor");
                    Random rnd4 = new Random();
                    int gazlama2 = rnd4.Next(50, 100);
                    mercedes.Gaz(gazlama2);
                    Console.WriteLine("hızlanıyorsunuz şerit sayısı arttı");
                    Console.WriteLine("güncel hızınız" + bmw.Hız);
                    break;
                default:
                    Console.WriteLine("yanlış bir değer seçtiniz");
                    break;


            }

            Console.WriteLine("bmw nin 3 dakikalık süreci");
            switch (RANDOM5)
            {
                case 1:
                    Console.WriteLine("önünüze hayvan çıkıyor");
                    Random rnd1 = new Random();
                    int frenkuvveti = rnd1.Next(20, 30);
                    if (bmw.Hız <= 30)
                    {

                    }
                    else
                    {
                        bmw.Fren(frenkuvveti);
                    }
                    
                    Console.WriteLine("frene basıyorsunuz");
                    Console.WriteLine("güncel hızınız" + bmw.Hız);
                    break;
                case 2:
                    Console.WriteLine("şerit sayısı düşüyor");
                    Random rnd2 = new Random();
                    int yavaşlama2 = rnd2.Next(10, 30);
                    if (bmw.Hız <= 20)
                    {

                    }
                    else
                    {
                        bmw.Fren(yavaşlama2);
                    }
                    
                    Console.WriteLine("yavaşlıyorsunuz,şerit sayısı azaldığı için");
                    Console.WriteLine("güncel hızınız" + bmw.Hız);
                    break;
                case 3:
                    Console.WriteLine("yol tamamen boş");
                    Random rnd3 = new Random();
                    int gazlama = rnd3.Next(50, 100);
                    bmw.Gaz(gazlama);
                    Console.WriteLine("hızlanıyorsunuz,yol boş");
                    Console.WriteLine("güncel hızınız" + bmw.Hız);
                    break;
                case 4:
                    Console.WriteLine("şerit sayısı artıyor");
                    Random rnd4 = new Random();
                    int gazlama2 = rnd4.Next(30, 50);
                    bmw.Gaz(gazlama2);
                    Console.WriteLine("hızlanıyorsunuz şerit sayısı arttı");
                    Console.WriteLine("güncel hızınız" + bmw.Hız);
                    break;
                default:
                    Console.WriteLine("yanlış bir değer seçtiniz");
                    break;







            }
            Console.WriteLine("mercedes in 3 dakikalık süreci");
            switch (RANDOM6)
            {
                case 1:
                    Console.WriteLine("önünüze hayvan çıkıyor");
                    Random rnd1 = new Random();
                    int frenkuvveti = rnd1.Next(20, 30);
                    if (bmw.Hız <= 30)
                    {
                        mercedes.Fren(10);
                    }
                    else
                    {
                        bmw.Fren(frenkuvveti);
                    }
                    
                    Console.WriteLine("frene basıyorsunuz");
                    Console.WriteLine("güncel hızınız" + mercedes.Hız);
                    break;
                case 2:
                    Console.WriteLine("şerit sayısı düşüyor");
                    Random rnd2 = new Random();
                    int yavaşlama2 = rnd2.Next(10, 30);
                    if (bmw.Hız <= 30)
                    {
                        mercedes.Fren(10);
                    }
                    else
                    {
                        bmw.Fren(yavaşlama2);
                    }
                    
                    Console.WriteLine("yavaşlıyorsunuz,şerit sayısı azaldığı için");
                    Console.WriteLine("güncel hızınız" + mercedes.Hız);
                    break;
                case 3:
                    Console.WriteLine("yol tamamen boş");
                    Random rnd3 = new Random();
                    int gazlama = rnd3.Next(50, 100);
                    mercedes.Gaz(gazlama);
                    Console.WriteLine("hızlanıyorsunuz,yol boş");
                    Console.WriteLine("güncel hızınız" + mercedes.Hız);
                    break;
                case 4:
                    Console.WriteLine("şerit sayısı artıyor");
                    Random rnd4 = new Random();
                    int gazlama2 = rnd4.Next(50, 100);
                    mercedes.Gaz(gazlama2);
                    Console.WriteLine("hızlanıyorsunuz şerit sayısı arttı");
                    Console.WriteLine("güncel hızınız" + mercedes.Hız);
                    break;
                default:
                    Console.WriteLine("yanlış bir değer seçtiniz");

                    break;




            }

            Console.WriteLine("YARIŞ BİTMİŞTİR,İZLEDİĞİNİZ İÇİN TEŞEKKÜRLER");
            Console.WriteLine("BMW NİN 3.DK SONU ULAŞTIĞI HIZ" + bmw.Hız);
            Console.WriteLine("MERCEDES NİN 3. DK SONU ULAŞTIĞI HIZ" + mercedes.Hız);

            if (bmw.Hız > mercedes.Hız)
            {
                Console.WriteLine("YARIŞIN KAZANANI BMW OLMUŞTIR");
                Console.WriteLine("TEBRİKLER");
            }
            else if (bmw.Hız == mercedes.Hız)
            {
                Console.WriteLine("BERABERE KALINMIŞTIR");
            }
            else
            {
                Console.WriteLine("YARIŞIN KAZANANI MERCEDES OLMUŞTIR");
                Console.WriteLine("TEBRİKLER");
            }
            Console.ReadLine();
        }
    }
}

    
    
    
    

                

            
        
       

