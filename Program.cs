using System.Collections;

namespace CollectionExamples
{
    internal class Program
    {

        static public void Main(String[] args)
        {

            Console.WriteLine("Main Method");

        }

        static void Main1() {
            ArrayList objArrayList = new ArrayList();
            objArrayList.Add("Ruttik");
            objArrayList.Add("seven");
            objArrayList.Add("jayesh");
            objArrayList.Add(100000);
            objArrayList.Add(true);
            objArrayList.Add("Ruttik");

            //-----------------------------
            objArrayList.Remove("Ruttik");
            objArrayList.RemoveAt(2);
            objArrayList.RemoveAt(3);
            //--------------------------------
            ArrayList o2 = new ArrayList();
            objArrayList.AddRange(o2);


            objArrayList.Insert(0, "new");
            objArrayList.InsertRange(0, o2);
            objArrayList.RemoveRange(0, 3);

            //objArrayList.IndexOf
            






            foreach (object item in objArrayList)
            {
                Console.WriteLine(item);
            }
        }

    }


}