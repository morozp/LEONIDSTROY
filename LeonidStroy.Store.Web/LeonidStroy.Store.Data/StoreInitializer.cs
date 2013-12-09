using System.Collections.Generic;
using System.Data.Entity;
using LeonidStroy.Store.Data.DomainObjects;

namespace LeonidStroy.Store.Data
{
    public class StoreInitializer : DropCreateDatabaseIfModelChanges<StoreContext>
    {
        protected override void Seed(StoreContext context)
        {
            var categories = new List<Category>
                                 {
                                     new Category {Name = "Тротуарная плитка"},
                                     new Category {Name = "Блоки"},
                                     new Category {Name = "Бордюры"},
                                     new Category {Name = "Заборы"},
                                     new Category {Name = "Другое"}
                                 };
            categories.ForEach(c => context.Category.Add(c));
            context.SaveChanges();


            var products = new List<Product>
                               {
                                   new Product {Name = "Кирпичик", CategoryId = 1},
                                   new Product {Name = "Кость", CategoryId = 1},
                                   new Product
                                       {
                                           Name = "Ромашка",
                                           CategoryId = 1,
                                           Elements =
                                               new List<Product>
                                                   {
                                                       new Product {Name = "Ромашка малая"},
                                                       new Product {Name = "Ромашка большая"}
                                                   }
                                       },
                                   new Product {Name = "Черепашка", CategoryId = 1},
                                   new Product {Name = "30х20х50", CategoryId = 2},
                                   new Product {Name = "50х50х50", CategoryId = 2},
                                   new Product {Name = "Тротуарный", CategoryId = 3},
                                   new Product {Name = "Декоротивный", CategoryId = 3},
                                   new Product {Name = "Вмноград", CategoryId = 4},
                                   new Product {Name = "Деревенский", CategoryId = 4},
                                   new Product {Name = "Ваза", CategoryId = 5},
                                   new Product {Name = "Лев", CategoryId = 5}
                               };

            products.ForEach(p => context.Products.Add(p));
            context.SaveChanges();
        }
    }
}

//
//    public class SchoolInitializer : DropCreateDatabaseIfModelChanges<SchoolContext> 
//    { 
//        protected override void Seed(SchoolContext context) 
//        { 
//            var students = new List<Student> 
//            { 
//                new Student { FirstMidName = "Carson",   LastName = "Alexander", EnrollmentDate = DateTime.Parse("2005-09-01") }, 
//                new Student { FirstMidName = "Meredith", LastName = "Alonso",    EnrollmentDate = DateTime.Parse("2002-09-01") }, 
//                new Student { FirstMidName = "Arturo",   LastName = "Anand",     EnrollmentDate = DateTime.Parse("2003-09-01") }, 
//                new Student { FirstMidName = "Gytis",    LastName = "Barzdukas", EnrollmentDate = DateTime.Parse("2002-09-01") }, 
//                new Student { FirstMidName = "Yan",      LastName = "Li",        EnrollmentDate = DateTime.Parse("2002-09-01") }, 
//                new Student { FirstMidName = "Peggy",    LastName = "Justice",   EnrollmentDate = DateTime.Parse("2001-09-01") }, 
//                new Student { FirstMidName = "Laura",    LastName = "Norman",    EnrollmentDate = DateTime.Parse("2003-09-01") }, 
//                new Student { FirstMidName = "Nino",     LastName = "Olivetto",  EnrollmentDate = DateTime.Parse("2005-09-01") } 
//            }; 
//            students.ForEach(s => context.Students.Add(s)); 
//            context.SaveChanges(); 
// 
//            var courses = new List<Course> 
//            { 
//                new Course { Title = "Chemistry",      Credits = 3, }, 
//                new Course { Title = "Microeconomics", Credits = 3, }, 
//                new Course { Title = "Macroeconomics", Credits = 3, }, 
//                new Course { Title = "Calculus",       Credits = 4, }, 
//                new Course { Title = "Trigonometry",   Credits = 4, }, 
//                new Course { Title = "Composition",    Credits = 3, }, 
//                new Course { Title = "Literature",     Credits = 4, } 
//            }; 
//            courses.ForEach(s => context.Courses.Add(s)); 
//            context.SaveChanges(); 
// 
//            var enrollments = new List<Enrollment> 
//            { 
//                new Enrollment { StudentID = 1, CourseID = 1, Grade = 1 }, 
//                new Enrollment { StudentID = 1, CourseID = 2, Grade = 3 }, 
//                new Enrollment { StudentID = 1, CourseID = 3, Grade = 1 }, 
//                new Enrollment { StudentID = 2, CourseID = 4, Grade = 2 }, 
//                new Enrollment { StudentID = 2, CourseID = 5, Grade = 4 }, 
//                new Enrollment { StudentID = 2, CourseID = 6, Grade = 4 }, 
//                new Enrollment { StudentID = 3, CourseID = 1            }, 
//                new Enrollment { StudentID = 4, CourseID = 1,           }, 
//                new Enrollment { StudentID = 4, CourseID = 2, Grade = 4 }, 
//                new Enrollment { StudentID = 5, CourseID = 3, Grade = 3 }, 
//                new Enrollment { StudentID = 6, CourseID = 4            }, 
//                new Enrollment { StudentID = 7, CourseID = 5, Grade = 2 }, 
//            }; 
//            enrollments.ForEach(s => context.Enrollments.Add(s)); 
//            context.SaveChanges(); 
//        } 
//    } 
//}