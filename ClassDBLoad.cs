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

        private ObservableCollection<ClassWithGroupModel> _classwithgroup;

        public ClassDBLoad()
        {

            _class = STGConnection.LoadClassComboData();

            _classwithgroup = STGConnection.LoadClassWithGroup();
        }


        public ObservableCollection<ClassModel> GetComboData()
        {
            return _class;

        }
        public ObservableCollection<ClassWithGroupModel> LoadClassWithGroup()
        {
                return _classwithgroup;
        }

    }
}
