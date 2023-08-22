problem-1 //Turnuva

/* 4 takımın katıldıgı bir turnuvada sampiyon takım en cok galibiyeti alan takım olacaktır. 
her takım her takımla maç yapmıstır. örneğin; bjk,ts,gs,fb takımlardır. 
sonuclar BJK-gs; FB-ts; TS-gs; GS-fb; BJK-ts; BJK-fb. sampiyon takımı bulunuz. (if-else kullanılacaktır)*/

bjk=0 ts=0 fb=0 gs=0

if(bjk>ts){bjk=bjk+1}
else{ts=ts+1}

if(bjk>fb){bjk=bjk+1}
else{fb=fb+1}

if(bjk>gs){bjk=bjk+1}
else{gs=gs+1}

if(ts>fb){ts=ts+1}
else{fb=fb+1}

if(ts>gs){ts=ts+1}
else{gs=gs+1}

{if(fb>gs){fb=fb+1}
else{gs=gs+1}}

////////////////////// buradan sonrası için 2 ayrı cozum; 1:

if(bjk>gs && bjk>gs && bjk>fb){şampiyon=bjk}
else if(ts>gs&&ts>fb){şampiyon=ts}
else if(gs>fb){şampiyon=gs}
else{şampiyon=fb}
return şampiyon;
/////////////////////// 2:
şampiyon=fb;
if(bjk>ts)
{
    if(bjk>gs)
    {
      if(bjk>fb){şampiyon=bjk}
    }
    else
    {
        if(gs>fb){şampiyon=gs}
    }
}
else 
{
    if(ts>gs)
    {
        if(ts>fb){şampiyon=ts}
    }
    else
    {
        if(gs>fb){şampiyon=gs}
    }
}
return fb;

