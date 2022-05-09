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

        private ObservableCollection<StudentModel> _student;

        private ObservableCollection<StudentGroupModel> _studentgroup;

        private ObservableCollection<GroupIDOnlyModel> _groupIDonly;
        public ClassDBLoad()
        {

            _class = STGConnection.LoadClassComboData();

            _classwithgroup = STGConnection.LoadClassWithGroup();

            _student = STGConnection.LoadStudents();

            _studentgroup = STGConnection.LoadAll();

            _groupIDonly = STGConnection.LoadGroupID();
        }


        public ObservableCollection<ClassModel> GetComboData()
        {
            return _class;

        }
        public ObservableCollection<ClassWithGroupModel> LoadClassWithGroup()
        {
                return _classwithgroup;
        }

        public ObservableCollection<StudentModel> LoadStudents()
        {
            return _student;
        }

        public ObservableCollection<StudentGroupModel> GetData()
        {
            return _studentgroup;
        }

        public ObservableCollection<GroupIDOnlyModel> LoadGroupID()
        {
            return _groupIDonly;
        }

    }
}
