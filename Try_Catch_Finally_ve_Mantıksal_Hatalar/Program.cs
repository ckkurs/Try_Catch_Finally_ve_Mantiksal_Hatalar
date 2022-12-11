using System;

namespace Try_Catch_Finally_ve_Mantıksal_Hatalar
{
    class Program
    {
        static void Main(string[] args)
        {
            try//hataya sebep olabilecek kodu buraya yazıyoruz.burdan integera çevrilemez bir deger geldiğinde hata fırlatacaktır.
            {
                Console.WriteLine("Bir sayı giriniz:");
                int sayi1=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş olduğunuz sayı:"+ sayi1);

            }
            catch(Exception ex)//bende diyorum ki bu hata geldiğinde Exception yakala,yakalanacak olan hataya ex diyorum.Burda hatanın ne olduğunu söylüyorum.
            {
                Console.WriteLine("Hata:"+ex.Message.ToString());
            } 
            finally//bir kod bloğu hata alsın almasın çalıştırılmasını istediğmiz bir başka kod bloğu varsa onu finally'e yazsın.Ben diyorumki hata alsın almasın kullanıcıya şu mesajı gösterelim.
            {
                Console.WriteLine("İşlem Tamamlandı");
            }
            
            try
            {
                //int a=int.Parse(null);//Parse string --> int
               // int a=int.Parse("test");
                int a=int.Parse("-23333333333");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş deger girdiniz");
                Console.WriteLine(ex);
               
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun degil");
                Console.WriteLine(ex);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Çok küçük ya da büyük bir deger girdiniz");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("İşlem Başarıyla Tamamlandı");
            }
        }
    }
}
