using ArrayListTask.Models;

namespace ArrayListTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
           IntArrayList arrayList = new IntArrayList();
            arrayList.Add(12);
            arrayList.Add(23);
            arrayList.Add(36);
            arrayList.Add(48);
            arrayList.Add(59);
            arrayList.Add(13);
            arrayList.Add(78);
            arrayList.Add(45);
            arrayList.Add(64);
            //Console.WriteLine(arrayList.ToString());
            //arrayList.RemoveAt(2);



            //arrayList.IndexOf(59);
            //arrayList.LastIndexOf(59);
            arrayList.RemoveAt(0);



            arrayList.GetInfo();
        }
    }
}
