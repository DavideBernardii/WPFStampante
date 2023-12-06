using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bernardi.davide._4i.Stampante.models
    /* 
- un costruttore che accetta colori specifici al massimo di valore 3
- un costruttore che crea una Pagina con colori random */
{
    public class Pagina
    {
        /* - 4 serbatoi di colore: CMYB */
        public int C { get; set; }
        public int M { get; set; }
        public int Y { get; set; }
        public int B { get; set; }

        public Pagina()
        {
            Random random = new Random();
            C = random.Next(0, 4);
            M = random.Next(0, 4);
            Y = random.Next(0, 4);
            B = random.Next(0, 4);
        }
        public Pagina(int C, int M, int Y, int B) 
        {
            if ( C < 4 && C > -1 && M < 4 && M > -1 && Y < 4 && Y > -1 && B < 4 && B > -1) 
            {
                this.C = C;
                this.M = M;
                this.Y = Y;
                this.B = B;
            }
        }
    }
}
