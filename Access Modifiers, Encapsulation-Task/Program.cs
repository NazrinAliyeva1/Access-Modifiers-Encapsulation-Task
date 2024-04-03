using Access_Modifiers__Encapsulation_Task.Methods;

namespace Access_Modifiers__Encapsulation_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isContinue = true;
            Weapon weapon = new Weapon(bulletcapac : 40, bulletcount: 14, firerate: 0.5f, isAutomaticMode : true);
            do
            {

                Console.WriteLine(@"Bütün məlumatları doldurmadan obyekt yaratmaq olmasın.
0 - İnformasiya almaq üçün
1 - Shoot metodu üçün
2 - Fire metodu üçün
3 - GetRemainBulletCount metodu üçün
4 - Reload metodu üçün
5 - ChangeFireMode metodu üçün
6 - Proqramdan dayandırmaq üçün
qısayoldur.
7 - Redaktə et :
T - Tutumu dəyişsin
S - Güllə sayı
D - Sıfırlama saniyəsi");

                int input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 0:
                        weapon.GetSet();
                        break;
                    case 1:
                        weapon.Shoot();
                        break;
                    case 2:
                        weapon.Fire();
                        break;
                    case 3:
                        int remainBulletCount = weapon.GetRemainBulletCount();
                        Console.WriteLine($"Qalan gulle sayi: {remainBulletCount}");
                        break;
                    case 4:
                        weapon.Reload();
                        break;
                    case 5:
                        weapon.ChangeFireMode();
                        break;
                    case 6:
                        isContinue = false;
                        break;
                        Console.Clear();

                    case 7:
                        Console.WriteLine("Redakte et:");
                        string editInput = Console.ReadLine();
                        switch (editInput.ToUpper())
                        {
                            case "T":
                                Console.WriteLine("Tutum deyisdirilsin: ");
                                int newBuletCapacity= Convert.ToInt32(Console.ReadLine());
                                weapon.BulletCapacity = newBuletCapacity;
                                break;
                            case "S":
                                Console.WriteLine("Gulle sayi deyisdirilsin: ");
                                int newBulletCount = Convert.ToInt32(Console.ReadLine());
                                weapon.BulletCount = newBulletCount;
                                break;
                            case "D":
                                Console.WriteLine("Sifirlama saniyesi deyissin.");
                                int newTesetTimeSeconds = Convert.ToInt32(Console.ReadLine());
                                weapon.ResetTimeSeconds = newTesetTimeSeconds;
                                break;
                            default:
                                Console.WriteLine("Duzgub bir secim etmediniz.");
                                break;
                        }
                        break;

                }
            }while(isContinue);


        }
    }
}
