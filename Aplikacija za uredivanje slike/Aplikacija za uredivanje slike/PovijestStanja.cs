using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Aplikacija_za_uredivanje_slike
{
    public class PovijestStanja<Bitmap> : LinkedList<Bitmap>
    {
        private readonly int _maxSize = 6;

        public void Push(Bitmap item)
        {
            this.AddFirst(item);
            if (this.Count > _maxSize)
                this.RemoveLast();
        }

        public Bitmap Pop()
        {
            var item = this.First;
            var temp = item.Next.Value;
            this.RemoveFirst();
            return temp;
        }
    }
}
