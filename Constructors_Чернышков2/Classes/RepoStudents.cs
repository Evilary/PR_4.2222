using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors_Чернышков2.Classes
{
    public class RepoStudents
    {
        public static List<Student> AllStudent()
        {
            List<Student> allStudents = new List<Student>();

            allStudents.Add(new Student("Болотов", "Евгений", "Олегович"));
            allStudents.Add(new Student("Иванов", "Александр", "Сергеевич"));
            allStudents.Add(new Student("Петров", "Максим", "Игоревич", false, 3));
            allStudents.Add(new Student("Сидоров", "Артем", "Владимирович",true));
            allStudents.Add(new Student("Козлов", "Дмитрий", "Александрович", false, 3));
            allStudents.Add(new Student("Новиков", "Кирилл", "Павлович"));
            allStudents.Add(new Student("Морозов", "Андрей", "Викторович"));
            allStudents.Add(new Student("Волков", "Илья", "Олегович"));
            allStudents.Add(new Student("Лебедев", "Станислав", "Юрьевич"));
            allStudents.Add(new Student("Семенов", "Роман", "Денисович", true));
            allStudents.Add(new Student("Федоров", "Владислав", "Артемьевич"));
            allStudents.Add(new Student("Медведев", "Георгий", "Станиславович"));
            allStudents.Add(new Student("Павлов", "Тимофей", "Романович"));
            allStudents.Add(new Student("Никитин", "Вадим", "Андреевич", true));
            allStudents.Add(new Student("Соловьев", "Глеб", "Вячеславович"));
            allStudents.Add(new Student("Белов", "Константин", "Михайлович", false, 3));
            allStudents.Add(new Student("Комаров", "Павел", "Геннадьевич"));
            allStudents.Add(new Student("Щербаков", "Степан", "Федорович"));
            allStudents.Add(new Student("Миронов", "Юрий", "Васильевич", true));
            allStudents.Add(new Student("Зайцев", "Богдан", "Тимурович"));
            allStudents.Add(new Student("Егоров", "Валерий", "Сергеевич"));
            allStudents.Add(new Student("Тихонов", "Олег", "Иванович", true));
            allStudents.Add(new Student("Кузьмин", "Федор", "Львович"));
            allStudents.Add(new Student("Андреев", "Сергей", "Николаевич"));


            return allStudents;
        }
    }
}
