problem-10 // Havuz 

/*Bir havuzun doldurulma süresi musluktaki suyun hızına göre ve yan bölümlerinin açılıp açılmamasına
göre değişiklik göstermektedir. Eğer ilk bölme 1 saat içinde dolarsa ikinci bölme de açılıp doldurulmaktadır.
Eğer 2. bölme de 1 saat içinde dolarsa 3. bölme açılmaktadır. 4.,5. bölmelerde aynı kuralla açılmaktadır 
ama musluk hızı her yeni bölmede katsayıya bağlı azalmaktadır.*ÖRN; hız 4 l/dk katsayı=1/2 ise sonraki 
bölmede hızı 2 l/dk olur. Yazacağınız kod ile kullanıcıdan havuzların büyüklüğü,musluk hızı, her yeni 
bölmede musluk hızının azalma katsayısı alınıp ne kadar sürede doldurulacağı bulunacaktır. Kullanıcıdan 
Read() komutu ile girdi alınır. Burada o kısmın kodu size verilecektir. */

int HavuzKapasite=Console.Read() // litre cinsinden verilecektir. Örn: 400 l
int muslukHizi= Console.Read()   // litre/dk cinsinden verilecektir. Örn: 2 l/dk.  Mesela 400 litrelik havuzu 200 dk'da doldurur. 
double katsayi= Console.Read()   // mesela 0.5 ise her yeni bölmede hız 0.5 ile çarpılarak ilerler.

