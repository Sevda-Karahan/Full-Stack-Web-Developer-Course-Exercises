using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyg34
{
    class Square : Polygon
    {
        //overriding render() method
        public override void render()
        {
            //base.render();
            Console.WriteLine("Rendering Square...");
        }
    }
}
