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
            return $"group_id:{ group_id}, group_name:{group_name}";
        }

    }

    public class StudentModel
    {
        public int student_id { get; set; }
        public string? given_name { get; set; }
        public string? family_name { get; set; }
        public int group_id { get; set; }
        public string? title { get; set; }
        public string? campus { get; set; }
        public string? phone { get; set; }
        public string? email { get; set; }
        public string? category { get; set; }

        public override string ToString()
        {
            return $"student_id: {student_id}, given_name: {given_name}, family_name: {family_name}， title: {title}, campus: {campus}, phone: {phone}, email: {email}, category: {category}";
        }
    }

    public class StudentGroupModel
    {
        public int group_id { get; set; }

        public string group_name { get; set; }

        public override string ToString()
        {

            return $"group_id:{ group_id}, group_name:{group_name}";
        }
    }

    public class GroupIDOnlyModel
    {
        public int group_id { get; set; }

        public override string ToString()
        {

            return $"{ group_id}";
        }
    }


}
