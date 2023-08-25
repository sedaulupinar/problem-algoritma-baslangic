problem-7 //Aritmetik ortalama
/* tam sayı listesi olusturun(array). bu sayı listesindeki sayıların ortalamasını 
(bulunan ortalama sayının ondalıklı olabileceğini unutmayınız) bulunuz. (foreach) */

int sayilar = Array (1,17,18,20,16,97)

double toplam=0
int sayiMiktari=0
foreach (sayi in sayilar) 
 {
    toplam=toplam+sayi
    sayiMiktari++
 }

double ortalama = toplam / sayiMiktari
return ortalama