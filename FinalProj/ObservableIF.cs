using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProj
{
    public interface ObservableIF
    {
        public void register(ObserverIF o);
        public void deregister(ObserverIF o);
        public List<string> getList(); //get list of promo strings 
    }
}
