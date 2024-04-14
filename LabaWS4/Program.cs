using StudentSpace;

internal class Program
{
    private static void Main(string[] args)
    {
        Student[] students = new Student[3] { new Student("Геннадьев", "А.И.", "17ВИ13", 19), new Student("Васильев", "Г.Д.", "11ПА20", 20), new Student() };
        ReaderSpace.Reader[] readers = new ReaderSpace.Reader[3] { new ReaderSpace.Reader("Геннадьев Алексей Игоревич", 132434, "Всемирная история", "14.09.2004", "+79541234536"), new ReaderSpace.Reader("Васильев Гектор Дмитриевич", 14489, "Палеонтология и археология", "19.08.2004", "+796543256743"), new ReaderSpace.Reader() };
        for (int i = 0; i < students.Length; i++)
        {
            students[i].getInfo(students[i]);
            readers[i].takeBook("Мастер и Маргарита", "Жизнь насекомых", "Ночной дозор");
            readers[i].returnBook(3);
        }
    }
}