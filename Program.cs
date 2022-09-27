//DIAGRAMMA VIDEOGAME

//Creare lo schema e-r con tutte le entità necessarie a gestire le informazioni di un archivio di E-sports.
//    1- Ciascun videogame ha un nome, una trama, una data di rilascio ed è prodotto da una software house, la quale, a sua volta, è identificata da un nome, una partita iva, città e nazione.
//    2- I videogames possono essere disponibili su diverse piattaforme (PlayStation 4, PlayStation 5, XBox One, XBox Serie X, Windows, Nintendo Switch, Google Stadia, ...) e hanno diverse categorie (avventura, strategia, RPG, sparatutto, calcio, ...) e classificazioni PEGI (PEGI 7, PEGI 12, PEGI 18, Violenza, Paura, Gioco d’azzardo, ...)
//    3- Periodicamente, vengono organizzati dei tornei a cui possono partecipare tutti i videogiocatori del mondo.
//    4- Ogni torneo è caratterizzato da un nome, l’anno e la città in cui si svolge.
//    5- I giocatori, al momento dell’iscrizione, devono fornire nome, cognome, nickname di gioco, e città di provenienza.
//    6- I videogames possono essere recensiti dai giocatori, i quali oltre al titolo e al testo, possono valutare i videogame con un rating da 1 a 5.
//    7- Ogni anno vengono votati i migliori videogiochi, che possono così vincere diversi premi (gioco dell’anno, miglior narrativa, miglior colonna sonora, miglior gioco indipendente, gioco più atteso, ...)


//TABELLA AUTOMOBILI

//per chi ha terminato, proseguiamo l’esercitazione con un esercizio differente.
//Concentriamoci ora sui dati di una tabella, che tipi di colonne dovremmo associare ad ogni campo?
//Ma sopratutto, quali campi decidiamo di rappresentare?
//Provate a modellizzare la struttura di una tabella per memorizzare tutti i dati riguardanti delle auto usate messe in vendita da un concessionario
//Esatto, andiamo a fantasia, ma non troppo!
//Cercate di immaginare ciò che realmente andrebbe progettato.
//Mi raccomando, una sola tabella, quella dell’automobile!


//DIAGRAMMA UNIVERSITA'

//Vi si chiede di modellizzare la struttura di un database con un modello ER per memorizzare tutti i dati riguardanti la gestione di un’università. Pertanto sono presenti le seguenti specifiche:
//Un’università possiede diversi dipartimenti, ognuno con uno o più corsi di laurea offerti;
//ogni corso di laurea è formato da diversi insegnamenti;
//ogni insegnamento può essere tenuto da diversi insegnanti. Inoltre ogni insegnamento prevede degli appelli d’esame;
//ogni studente è iscritto ad un corso di laurea;
//per ogni appello d’esame a cui lo studente ha partecipato, è necessario memorizzare il voto ottenuto, anche se non sufficiente
//Modellate dunque tutte le entità, pensando ai campi che un’università potrebbe aver bisogno per ogni entità. Infine pensate bene a tutte le relazioni, indicandone la cardinalità, che esistono fra le vostre entità.