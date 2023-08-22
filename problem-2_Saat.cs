problem-2 // Saat
/* eğer saat 00.00 06.00 arası ise gece; 06-12 arası ise sabah; 12-18 arası ise gündüz; 
18-00 arası ise aksam yazdırın. şuanki saat bilgisine "Datetime.Now" diyerek ulaşablirsiniz. (if-else)*/

saat= Datetime.Now
if(saat<12.00 && saat>6.00){return "sabah"}
if(saat<00.00 && saat>6.00 ){return "gece"}
if(saat<18.00 && saat>12.00){return "gündüz"}
if(saat<00.00 && saat>18.00){return "akşam"}