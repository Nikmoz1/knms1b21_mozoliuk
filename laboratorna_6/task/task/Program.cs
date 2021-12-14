using System.Collections;

class Students
{
    string fullName { get; set; }
    int age { get; set; }
    string phoneNum { get; set; }
    string street { get; set; }

    public Students(string fullName, int age, string phoneNum, string street)
    {
        this.fullName = fullName;
        this.age = age;
        this.phoneNum = phoneNum;
        this.street = street;
    }

    public override string ToString()
    {
        return $"ПIБ: {fullName}, Вiк: {age}, Номер телефону: {phoneNum}, Вулиця проживання: {street}";
    }
}

internal class CollectionType<T> : IEnumerable<T> where T : Students
{
    List<T> list = new List<T>();

    public CollectionType()
    {
        list = new List<T>();
    }

    public int Count
    {
        get { return list.Count; }
    }

    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= Count)
            {
                throw new IndexOutOfRangeException();
            }
            return list[index];
        }
        set
        {
            if (index < 0 || index >= Count)
            {
                throw new IndexOutOfRangeException();
            }
            list[index] = value;
        }
    }

    public void Add(T student)
    {
        list.Add(student);
    }

    public T Remove(T student)
    {
        var element = list.FirstOrDefault(h => h == student);
        if (element != null)
        {
            list.Remove(element);
            return element;
        }
        throw new NullReferenceException();
    }

    public void Sort()
    {
        list.Sort();
    }

    public IEnumerator<T> GetEnumerator()
    {
        return list.GetEnumerator();
    }

    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Students stud1 = new Students("Жванецький Д. М.", 18, "+380234567890", "Шевченко 9/5");
        Students stud2 = new Students("Кульченко О. К.", 19, "+380934679820", "Соборна 16");
        Students stud3 = new Students("Сяо Д.", 19, "+380666792031", "Драгоманова 14");
        Students stud4 = new Students("Борщанов Є. П.", 18, "+380676492250", "Центральна 7");

        CollectionType<Students> collection = new CollectionType<Students>();
        collection.Add(stud1);
        collection.Add(stud2);
        collection.Add(stud3);
        collection.Add(stud4);

        foreach (Students s in collection)
        {
            Console.WriteLine(s.ToString());
        }
    }
}
