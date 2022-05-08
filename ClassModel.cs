using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMIS
{
    public class ClassModel
    {
        public int class_id { get; set; }
        public int group_id { get; set; }
        public string? day { get; set; }
        public string? start { get; set; }
        public string? end { get; set; }
        public string? room { get; set; }

        public override string ToString()
        {
            return $"{class_id}";
        }

    }

    public class ClassWithGroupModel
    {
        public int class_id { get; set; }
        public int group_id { get; set; }
        public string? group_name { get; set; }
        public string? day { get; set; }
        public string? start { get; set; }
        public string? end { get; set; }
        public string? room { get; set; }

        public override string ToString()
        {
            return $"Class ID : {class_id} - Group ID : {group_id} - Group Name : {group_name}";
        }

    }

}
