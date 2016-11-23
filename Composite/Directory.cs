using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Directory:BaseFile
    {
        List<BaseFile> files = new List<BaseFile>();
        public Directory(string name):base(name)
        {
            
        }

        public void Add(BaseFile baseFile)
        {
            files.Add(baseFile);
        }

        public void Remove(BaseFile baseFile)
        {
            files.Remove(baseFile);
        }

        public override void Display(int depth=0)
        {
            base.Display(depth);
            files.ForEach(x => x.Display(depth + 1));
        }
    }
}
