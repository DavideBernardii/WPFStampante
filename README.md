# WPFStampante
## UML
![WPFStampante drawio](https://github.com/DavideBernardii/WPFStampante/assets/127590023/ba6ab9db-b7bd-4ecc-b76c-b2d91e59dfcb)
## Scopo codice
Creare:
Una classe "Stampante" con al suo interno:
- 4 serbatoi di colore: CMYB e un cassetto di fogli (tutte property int)
- un metodo bool Stampa( Pagina p ) (che torna false, se l'inchiostro non è sufficiente per stampare)
- un metodo int StatoInchiostro( Colore c ) che torna la quantità di inchiostro presente nei 4 serbatoi.
- un metodo int StatoCarta() che mi ritorna la quantità di fogli nel cassetto
- un metodo void SostituisciColore( Colore c ) che rimpiazza un serbatoio di inchiostro e lo riporta a 100
- un metodo void AggiungiCarta( int qta ) che aggiunge fogli fino ad un max di 200

Classe "Pagina" 
- 4 attributi CMYB che, se usata per stampare, consuma i serbatoi della stampante.
- un costruttore che accetta colori specifici al massimo di valore 3
- un costruttore che crea una Pagina con colori random

poi bisogna fare in modo che:
  - alla riapertura le % dei colori della stampante sono invariati.
  - alla riapertura il numero di foglii nella stampante è invariato.
