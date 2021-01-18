using LibModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibController
{
    public class cnDataSave
    {
        public List<Student> _cStudentList = new List<Student>();

        public cnDataSave()
        {
            Init();
        }

        private void Init()
        {
            // Data
            List<string> cStudentNameList = new List<string>(){ "김창덕", "전현후", "최원용", "정은진", "박성열", "김용", "김범준" };
            List<string> cElementaryNameList = new List<string>() { "역촌", "불광", "하남", "은사", "응암", "연서", "응암" };
            List<string> cMiddleNameList = new List<string>() { "신진", "충암", "서초", "강남", "강서", "전진", "응암" };
            List<string> cHighNameList = new List<string>() { "신진과학", "충암", "서초", "강남공업", "순천", "영진", "구파발" };

            for (int i = 0; i < cStudentNameList.Count; i++)
            {
                Student student = new Student(cStudentNameList[i]);
                student.school.Elementary = cElementaryNameList[i];
                student.school.Middle = cMiddleNameList[i];
                student.school.High = cHighNameList[i];

                _cStudentList.Add(student);
            }
        }
    }
}
