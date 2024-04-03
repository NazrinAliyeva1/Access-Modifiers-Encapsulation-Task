using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifiers__Encapsulation_Task.Methods
{
    public class Weapon
    {
        int _bulletCapacity;
        int _bulletCount;
        float _fireRate;
        bool _isAutomaticMode;
        int _resetTimeInSecond;

        public int BulletCapacity
        {
            get { return _bulletCapacity;}
            set { _bulletCapacity = value;}
        }
        public int BulletCount
        {
            get { return _bulletCount; }
            set { _bulletCount = value; }
        }
        public float FireRate
        {
            get { return _fireRate; }
            set { _fireRate = value; }
        }
        public bool IsAutomaticMode
        {
            get { return _isAutomaticMode; }
            set { _isAutomaticMode = value; }
        }
        public int ResetTimeSeconds
        {
            get { return _resetTimeInSecond; }
            set { _resetTimeInSecond = value; }
        }
            public Weapon(int bulletcapac, int bulletcount, float firerate, bool isAutomaticMode)
        {
            _bulletCapacity = bulletcapac;
            _bulletCount= bulletcount;
            _fireRate= firerate;
            _isAutomaticMode = isAutomaticMode;


        }

        public void Fire()
        {
            if (_bulletCount == 0)
            {
                Console.WriteLine("Daraqda gulle yoxdur. Yeniden doldurun.");
                return;
            }
            int buletsFired = 0;
            DateTime startTime = DateTime.Now;

            while (_bulletCount>0)
            {
                Shoot();
                buletsFired++;
                if (!_isAutomaticMode)
                {
                    break;//Tək atış rejimində bir dəfə atəş etdikdən sonra döngədən çıxın
                }
            }
            DateTime endTime = DateTime.Now;
            TimeSpan totalTime = endTime - startTime;
            float fireRate = buletsFired / (float)totalTime.TotalSeconds;

            Console.WriteLine($"Gullelerin hamisi ateslendi. Bitme deqiqesi: {totalTime}. Atis derecesi: {fireRate} gulle/saniye. (Atis derecesi, 1 saniyede atilan gulle sayisini ifade edir.)");

        }
        public void GetSet()
        {
            Random random = new Random();
            byte usedBullet = Convert.ToByte(random.Next(_bulletCount));
            _bulletCount -= usedBullet;
            if (_bulletCount < 0)
            {
                _bulletCount = 0;
            }
            Console.WriteLine($"Used bullet {usedBullet}. Bulletcount : {_bulletCount}");
        }
        public void Shoot()
        {
            if (_bulletCount > 0)
            {
                Console.WriteLine("Bir gulle atildi.");
                _bulletCount--;
            }
            else
            {
                Console.WriteLine("Daraqda gule qalmadi. Yeniden doldurun.");

            }

        }
        public int GetRemainBulletCount()
        {
            return _bulletCapacity - _bulletCount;

        }
        public void Reload()
        {
            //daragi yeniden doldurur.
            //_bulletCount = _bulletCapacity;
            int bulletsAdd = _bulletCapacity - _bulletCount;
            _bulletCount += bulletsAdd;
            Console.WriteLine($"Daraq yeniden dolduruldu. Elave olunan mermi sayi: {bulletsAdd}. Yeni mermi sayi: {_bulletCount}");
        }
        public void ChangeFireMode()
        {
            if (_isAutomaticMode)
            {
                _isAutomaticMode = false;
                Console.WriteLine("Atis modu deyisdirildi: Tekli");
            }
            else
            {
                _isAutomaticMode = true;
                Console.WriteLine("Atis modu deyisdirildi: Avtomatik");
            }
        }
    }

}
