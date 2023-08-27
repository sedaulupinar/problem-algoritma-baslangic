problem-1 //Faiz
/* mart ayında %4'den başlayıp her ay %1 artarak sonraki marta kadar %16'ya yükselen bir faiz sistemi 
vardır. Anapara, hangi ayda bulunduğumuz ve halihazırda hesapta olan para verilmektedir. 
Hesapta ödeme için yeterli bakiye yoksa yetersiz bakiye uyarısı verdirin*/

int anaPara;
int kacinciAy;
int hesaptakiPara;

 float faizOrani = 0.04 + (kacinciAy - 1) * 0.01;

 float faizliMiktar = anaPara + anaPara * faizOrani;

if (faizliMiktar <= hesaptakiPara) 

{printf("Ödeme için yeterli bakiye mevcut.\n");} 
        
else printf("Yetersiz bakiye. Gerekli miktar: %.2f\n", faizliMiktar);

return 0;




return ("Yetersiz Bakiye!!!")