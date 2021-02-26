using System.Collections.Generic;
using Tasks.HelpClasses;

namespace Tasks
{
    public class Task4
    {
        /*
         * Desenvolva um método que retorne todos os estudantes do Repositório que nasceram em 2020      
         * Dica: A classe Repository possui as informações dos Students
         */
        public static List<Student> GetStudentsByBirth() {
            var repository = new Repository();
            List<Student> students = repository.Students;
            List<Student> studentsBirth2020 = new List<Student>();

            foreach (Student student in students)
            {
                if (student.Birth.Year == 2020)
                {
                    studentsBirth2020.Add(student);
                }
            }
            return studentsBirth2020;
        }
    }
}
