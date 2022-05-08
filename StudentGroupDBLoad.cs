using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GMIS
{
    public class StudentGroupDBLoad
    {
        private ObservableCollection<StudentGroupModel> studentgroup;

        public StudentGroupDBLoad()
        {

            studentgroup = STGConnection.LoadAll();
        }

      
        public ObservableCollection<StudentGroupModel> GetData()
        {
            return studentgroup;
        }
    }
}
