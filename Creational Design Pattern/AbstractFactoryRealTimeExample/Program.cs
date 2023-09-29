namespace AbstractFactoryRealTimeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ISourceCourseFactory offlineSourceCourseFactory = new OfflineSourceCourseFactory();

            var course = offlineSourceCourseFactory.GetCourse();
            Console.WriteLine("FrontEnd Course and Source Details");
            Console.WriteLine(course.GetCourseName());
            Console.WriteLine(course.GetCourseFee());
            Console.WriteLine(course.GetCourseDuration());

            var source = offlineSourceCourseFactory.GetSource();
            Console.WriteLine(source.GetSourceName());

            Console.WriteLine("\n-----------------------------\n");

            ISourceCourseFactory onlineSourceCourseFactory = new OnlineSourceCourseFactory();

            var course2 = onlineSourceCourseFactory.GetCourse();
            Console.WriteLine("BackEnd Course and Source Details");
            Console.WriteLine(course2.GetCourseName());
            Console.WriteLine(course2.GetCourseFee());
            Console.WriteLine(course2.GetCourseDuration());

            var source2 = onlineSourceCourseFactory.GetSource();
            Console.WriteLine(source2.GetSourceName());

            Console.ReadKey();
        }
    }
}