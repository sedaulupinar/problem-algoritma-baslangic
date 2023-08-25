problem-8 //EnBuyukUcuncu
/*rastgele 10 elemanlı bir int sayı listesi olusturun. Bu sayı listesinin en buyuk ucuncu elemanını bulunuz.
(bir sayıyı rastgele uretmek icin Random() methodu kullanılır) (for,foreach,if)*/

array int[] sayiListesi = []
 for(int i=0; i<10;i++)
 {
   sayiListesi[i]=Random(1,100)
 }

int sayac=1
while(sayac<=3)
{
  int counter=0
  foreach(sayi in sayilar)
  {
    if(sayi>enbuyuk)
    {
        enbuyuk=sayi
        index=counter
    }
    counter++
  }
  if(sayac<3)
  {
    sayilar[index]=0
  }
  else 
  {EnBuyukUcuncu=enbuyuk}
  sayac++
}
return EnBuyukUcuncu