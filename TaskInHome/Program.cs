//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


//using TaskInHome;
#region TaskinClass

//Person person = new Person("Saiq","Kazimov",18);
//Person person2 = new Person("Azer", "Kazimov", 54);
//Person person3 = new Person("Zohre", "Kazimova",45);
//Person person4 = new Person("Nigar", "Kazimova", 27);
//Person person5 = new Person("Ferid", "Kazimova", 78);

//Person[] arry = { person, person2, person3, person4, person5 };

//static void GetPersonsByAge(Person[]arry)
//{
//    foreach (var item in arry)
//    {
//        if (item.Age > 20)
//        {
//            Console.WriteLine(item.Name+" "+ item.Surname);
//        }
//    }
//}

//GetPersonsByAge(arry);

//Student student = new Student("Shaiq", "Kazimov", "Sedmoy", 24);
//Student student2 = new Student("Ali", "Talibov", "Nizami", 21);
//Student student3 = new Student("Cavid", "Ismayilzade", "Sulutepe", 23);
//Student student4 = new Student("Ceyhun", "Alizade", "Buzovna", 24);

//Student[] people = { student, student2, student3, student4 };


//static void Searh(Student[] people)
//{
//    string text = "C";
//    foreach (var item in people)
//    {
//        if (item.Name.ToLower().Contains(text.ToLower()) || item.Surname.ToLower().Contains(text.ToLower()))
//        {
//            Console.WriteLine(item.Name + " " + item.Surname);
//        }
//    }
//}
//Searh(people);





#endregion


#region Employee

//static void Search(int n,int m)
//{
//    var workers = GetWorkersInf();
//    foreach (var item in workers)
//    {
//        if (item.Salary > n && item.Salary<m)
//        {
//            Console.WriteLine(item.Name + " " + item.Surname + " " + item.Age + " " + item.Salary);
//        }
//    }
//}


//Search(1000,2000);


//static Employee[] GetWorkersInf()
//{
//    Employee employee = new Employee("Saiq", "Kazimov", 25, 1500);
//    Employee employee2 = new Employee("Cavid", "Ismayilzade", 22, 1500);
//    Employee employee3 = new Employee("Ismayil", "Kerimzade", 25, 1800);
//    Employee employee4 = new Employee("Eli", "Eliyev", 23, 900);
//    Employee employee5 = new Employee("Ayxan", "Aliyev", 27, 850);

//    Employee[] worker = { employee, employee2, employee3, employee4, employee5 };
//    return worker;

//}
#endregion


#region Calculator
//Calculator calculator = new Calculator();

//calculator.Calculation();
#endregion



#region Doctor

//doctorsz = GetDoctorsInfo();


//Doctor[]arr = GetDoctorsInfo();

//SearchDoc(new DateTime(1993, 05, 25), new DateTime(2002, 12, 15));

//static void SearchDoc(DateTime n, DateTime m)
//{
//    Doctor[] arr = GetDoctorsInfo();

//    foreach (var item in arr)
//    {
//        if (item.Birhtday > n && item.Birhtday < m) ;
//        {

//            Console.WriteLine(item.Name + " " + item.Surname);
//        }
//    }
//}

//static Doctor[] GetDoctorsInfo()
//{
//    Doctor doctor = new Doctor("Nebi", "Eliyev", "Xetai", new DateTime(1992, 04, 11));
//    Doctor doctor2 = new Doctor("Eli", "Eliyev", "Sedmoy", new DateTime(1997, 11, 26));
//    Doctor doctor3 = new Doctor("Aygun", "Eliyev", "Vasmoy", new DateTime(1999, 05, 28));
//    Doctor doctor4 = new Doctor("Zakir", "Velizade", "Xetai", new DateTime(2002, 07, 21));
//    Doctor doctor5 = new Doctor("Ceyhun", "Eliyev", "Goranboy", new DateTime(2006, 08, 11));

//    Doctor[] arr = { doctor, doctor2, doctor3, doctor4, doctor5 };
//    return arr;
//}

#endregion


#region Service Task
//using Servis1;
////Custom custom = new Custom();
////custom.GetFactorial(5);

//int[] arry = { 14, 12, 12, 11, 10, 9,};
//Custom custom = new Custom();
//custom.GetArr(arry);



#endregion
