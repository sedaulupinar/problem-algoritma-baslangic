problem-5 // Kitap
/* kütüphane de 100 kitaplık yer vardır. Eğer mevcut kitap sayısı 100'ü geçerse en eski kitap 
tespit edilip depoya atılmalıdır. Her kitabın gelis zamanına göre kodunun son 4 rakamı ay/yıl AAYY 
biçiminde içerir. ÖRN: haziran 2022 = > 0622.  100 kitabı geçtiği zaman atılması gereken kitabı bulunuz.
*/

int toplamKitapSayisi;
int kitapKodu;
if(kitapsayisi>100) kitap sayisi=kitapsayisi--

for (int i = 1; i < toplamKitapSayisi; i++) {
 if (strcmp(kitaplar[i].kod, kitaplar[enEskiIndex].kod) < 0) {
 enEskiIndex = i;

printf("Depoya konulacak kitap kodu: %s\n", kitaplar[enEskiIndex].kod);

for (int i = enEskiIndex; i < toplamKitapSayisi - 1; i++) {
            strcpy(kitaplar[i].kod, kitaplar[i + 1].kod);
        }

toplamKitapSayisi--;

        printf("Toplam kitap sayisi: %d\n", toplamKitapSayisi);
    }

    return atilacakKitapKodu