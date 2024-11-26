using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARABA_OYUNU_OOP
{
   
    
        public class araba
        {
            public int Hız { get; set; }
            public string Marka { get; set; }
            public string Renk { get; set; }

            public virtual void korna()
            {
                Console.WriteLine("düttttttttttttttt");
            }

            public virtual void Fren(int azalanhız)
            {
                Hız = Hız - azalanhız;
            }

            public virtual void Gaz(int artanhız)
            {
                Hız = Hız + artanhız;
            }

            public virtual void dörtlü()
            {
                Console.WriteLine("araba dörtlülerini yakıyor");
            }
        }
    }



