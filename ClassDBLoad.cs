using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMIS
{
    public  class ClassDBLoad
    {
        private ObservableCollection<ClassModel> _class;

        public ClassDBLoad()
        {

            _class = STGConnection.LoadClassComboData();
        }


        public ObservableCollection<ClassModel> GetComboData()
        {
            return _class;
        }
    }
}
