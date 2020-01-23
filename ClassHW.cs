using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA
{
    class ClassHW
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private int age;
        public string Show()
        {
            string answer;
            answer = "Полное имя: " + firstName + " " + middleName + " " + lastName + "\nВозрас: " + age;
            return answer;
        }
        public void SetFirstName(string firstName)
        {
            this.firstName = firstName;
        }
        public string GetFirstName()
        {
            return firstName;
        }

        public void SetMiddleName(string middleName)
        {
            this.middleName = middleName;
        }
        public string GetMiddleName()
        {
            return middleName;
        }

        public void SetLastName(string lastName)
        {
            this.lastName = lastName;
        }
        public string GetLastName()
        {
            return lastName;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }
        public int GetAge()
        {
            return age;
        }
    }
}
