using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace bernardi.davide._4i.Stampante.models
{

     
    public class Stampante
    {
        /* - 4 serbatoi di colore: CMYB */
        public int C { get; set; }
        public int M { get; set; }
        public int Y { get; set; }
        public int B { get; set; }

      /* ...e un cassetto di fogli(tutte property int) */
        public int Fogli { get; set; }
        public Stampante()
        {
            C = M = Y = B = 100;
            Fogli = 200;
        }
       /* - un metodo bool Stampa(Pagina p) (che torna false, se l'inchiostro non è sufficiente per stampare)*/
       public bool Stampa( Pagina p ) 
        {
            if( (Fogli>0) && 
                (C >= p.C) && 
                (M >= p.M) && 
                (Y >= p.Y) && 
                (B >= p.B)
                ) {
 
                C -= p.C;
                M -= p.M;
                Y -= p.Y;
                B -= p.B;
                Fogli--;
                
                return true;
            }
            return false;
        }
        /* - un metodo int StatoInchiostro(Colore c) che torna la quantità di inchiostro presente nei 4 serbatoi. */
        public int StatoInchiostro(int c) 
        {
            switch (c)
            {
                case 0: return C;
                case 1: return M;
                case 2: return Y;
                case 3: return B;
                default: return 0;
            }
        }
        /* un metodo void AggiungiCarta(int qta) che aggiunge fogli fino ad un max di 200*/
        public void AggiungiCarta(int qta) 
        {
            if((Fogli + qta) < 201) { 
            Fogli = Fogli + qta;
            }
        }
        /*
- un metodo int StatoCarta() che mi ritorna la quantità di fogli nel cassetto */
        public int StatoCarta() 
        {
            return Fogli;
        }
        /*
- un metodo void SostituisciColore( Colore c ) che rimpiazza un serbatoio di inchiostro e lo riporta a 100
*/
        public void SostituisciColore(int C) 
        {
            switch(C) 
            {
                case 0: this.B = 100;
                    break;
                case 1: this.Y = 100;
                    break;
                case 2: this.M = 100;
                    break;
                case 3: this.C = 100;
                    break;
                default: throw (new Exception());
            }
        }
    }
}
