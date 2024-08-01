using System.Collections;

namespace C__Advanced_02_Collections
{
    internal class Program
    {
        #region Method [Non_Generics]
        //public static int  SumArray(ArrayList arrayList)
        //{
        //    int Sum = 0;
        //    if (arrayList != null)
        //    {
        //        for (int i = 0; i < arrayList.Count; i++)
        //        {
        //            Sum += (int)arrayList[i];

        //        }
        //        return Sum;
        //    }

        //    return Sum;

        //} 
        #endregion
        #region Method [Generics]
        #region List
        //public static int SumArray(List<int> list)
        //{
        //    int Sum = 0;
        //    if (list != null)
        //    {
        //        for (int i = 0; i < list.Count; i++)
        //        {
        //            Sum += list[i];

        //        }
        //        return Sum;
        //    }

        //    return Sum;

        //   } 
        #endregion
        #endregion

        static void Main(string[] args)
        {
            #region Collections [Non Generics]
            //ArraList
            //ArrayList arrayList = new ArrayList();
            ////arrayList Refer To Empty Array
            ////arrayList Refer Size=0
            ////ArrayList Not Have Length But Have : 
            ////Count:This Refer To Actual Element In ArrayList
            ////Capacity:This Refer To Size Elements That Array Can Hold
            //Console.WriteLine($"Count This Array is {arrayList.Count}   And Capacity This Array is {arrayList.Capacity}  ");// 0 0
            ////To Add Element IN Array 
            //arrayList.Add(1);
            ////first Add Element In Array Affect IN size (Capacity) Increment Into  Default Size [4]  
            //Console.WriteLine($"Count This Array is {arrayList.Count}   And Capacity This Array is {arrayList.Capacity}  ");//0 4
            ////To Add Range Values In Array
            //arrayList.AddRange(new int[] {2,3,4});
            //Console.WriteLine($"Count This Array is {arrayList.Count}   And Capacity This Array is {arrayList.Capacity}  ");//4 4
            //arrayList.Add(5);
            ////add element greeter than size affect in :
            //    //increment capacity to double size [4*2]==>[8]
            //    //create new array have old value {1,2,3,4} + New Value {5}
            //Console.WriteLine($"Count This Array is {arrayList.Count}   And Capacity This Array is {arrayList.Capacity}  ");//5 8


            // To Create ArrayList With Detect El Capacity
            //ArrayList arrayList2 = new ArrayList(5) { 1,2,3,4,5};
            //Console.WriteLine($"Count This Array is {arrayList2.Count}   And Capacity This Array is {arrayList2.Capacity}  ");//5 8
            //arrayList2.Add(6);
            //arrayList2.Add("10");
            ////Increase Size To Double [2*5==>10]
            ////Note : In Array have count 6 and size 10 == >>10-6=4
            ////4 ====> Unused and this not improve 
            //// sol
            //arrayList2.TrimToSize();
            ////create new array have size = count 
            //Console.WriteLine($"Count This Array is {arrayList2.Count}   And Capacity This Array is {arrayList2.Capacity}  ");//5 8
            ////new array have [old values + new values ]

            //    int Result=SumArray(arrayList2);
            //Console.WriteLine($"Result Sum Array is {Result}");



            #endregion

            #region Collection [ Generics ]
            //Generics Collections [Lists - Queue - Stack - LinkedList - Dictionary]
            #region Lists
            #region List Details
            // Lists
            //List<int> Numbers=new List<int>();
            ////use list with parameterless constructors
            ////Numbers refer to empty array
            ////Number have [size/capacity=0,count=0]
            //Console.WriteLine($"Count Of this array is {Numbers.Count} and Capacity in this array is {Numbers.Capacity} ");
            ////to add value in array 
            //Numbers.Add(1);
            ////create new array at heap with default size/capacity is 4
            //Console.WriteLine($"Count Of this array is {Numbers.Count} and Capacity in this array is {Numbers.Capacity} ");
            ////to Add range in array 
            //Numbers.AddRange(new int[] {1,2,3});    
            //Console.WriteLine($"Count Of this array is {Numbers.Count} and Capacity in this array is {Numbers.Capacity} ");
            //Numbers.Add(5);
            ////create new array at heap with double size/capacity is 4*2==>8
            //Console.WriteLine($"Count Of this array is {Numbers.Count} and Capacity in this array is {Numbers.Capacity} ");


            ////to create list with detect size
            //List<int> Num=new List<int>(5) { 4,5,58,4,8};
            //Console.WriteLine($"Count Of this array is {Num.Count} and Capacity in this array is {Num.Capacity} ");
            //for (int i = 0; i < Num.Count; i++)
            //{
            //    Console.Write("" + "  " +  Num[i]);

            //}
            //int Result=SumArray(Num);
            //Console.WriteLine($"\n\n\nResult Sum The Array is {Result}"); 
            #endregion


            #region List Method
            //List<int> Num = new List<int>(4) {1 ,2, 3, 4 };
            //Console.WriteLine($"Count Of this array is {Num.Count} and Capacity in this array is {Num.Capacity} ");
            //Num.Add(5);
            //Console.WriteLine($"Count Of this array is {Num.Count} and Capacity in this array is {Num.Capacity} ");
            //Num.AddRange(new int[] {6,7});
            //Console.WriteLine($"Count Of this array is {Num.Count} and Capacity in this array is {Num.Capacity} ");
            //Num.Insert(6, 8);
            //Console.WriteLine($"Count Of this array is {Num.Count} and Capacity in this array is {Num.Capacity} ");
            //Num.InsertRange(4,new int[] {9,10});
            //Console.WriteLine($"Count Of this array is {Num.Count} and Capacity in this array is {Num.Capacity} ");
            //int Index= Num.BinarySearch(3);
            //Console.WriteLine($"Index is = {Index}");



            #endregion
            #endregion


            #region LinkedList
            ////To Use Parameterless Constructor
            //LinkedList<int> linkedList = new LinkedList<int>();
            //Console.WriteLine($"Count This LinkedList Is {linkedList.Count}");
            ////To Add Element In First LinkedList
            //linkedList.AddFirst(1);
            //Console.WriteLine($"Count This LinkedList Is {linkedList.Count}");

            ////To Add Element In Lst LinkedList
            //linkedList.AddLast(3);
            //Console.WriteLine($"Count This LinkedList Is {linkedList.Count}");

            ////To Show Elements In array


            //foreach (int i in linkedList) 
            //{
            //    Console.Write(""+ " "+ i);
            //}

            //To Add Element In Specific Place

            //LinkedListNode<int>? After = linkedList.Find(1);

            //linkedList.AddAfter(After, 2);

            //Console.WriteLine("\n\n");
            //foreach (int i in linkedList)
            //{
            //    Console.Write("" + " " + i);
            //}

            //Or

            //LinkedListNode<int>? before = linkedList.Find(3);

            //linkedList.AddBefore(before!, 2);

            //Console.WriteLine("\n\n");
            //foreach (int i in linkedList)
            //{
            //    Console.Write("" + " " + i);
            //}



            #endregion

            #region Stack
            //Stack ==>First In Last Out [FILO]
            //Stack ==>Last In First Out [LIFO]
            // Stack<int> stack = new Stack<int>();
            // //To Add Element In Stack
            // stack.Push(1);
            // stack.Push(2);
            // stack.Push(3);


            // //to print All Element From Stack
            // foreach (int  item in stack)
            // {
            //     Console.Write(""+ item + " "); //  3 2 1
            // }

            // //to return element from stack that is top stack
            //int peek= stack.Peek();
            // Console.WriteLine($"\n\n Peek Is {peek}");
            // foreach (int item in stack)
            // {
            //     Console.Write("" + item + " "); //  3 2 1
            // }

            // // to delete top element from stack
            //     //Pop() :Unsafe
            //     //Note Tips Using TryPop()
            // int pop= stack.Pop();
            // Console.WriteLine($"\n\n Pop Is {pop}");
            // foreach (int item in stack)
            // {
            //     Console.Write("" + item + " "); //   2 1
            // }
            // stack.Pop();
            // stack.Pop();
            // stack.Pop();//InvalidOperationException

            #endregion

            

            #region Queue
            //Queue : First IN First Out [FIFO]
            //Queue<int> queue = new Queue<int>();
            ////To Add Element TO Queue
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);

            ////to print all element in queue
            //foreach (int i in queue)
            //{
            //    Console.Write(""+ " " + i); // 1 2 3 4 
            //}

            //Console.WriteLine("\n\n==================");

            ////to get first element in queue without delete it
            //int Peek= queue.Peek();
            //Console.WriteLine($"Peek Is {Peek}");
            //foreach (int i in queue)
            //{
            //    Console.Write("" + " " + i); // 1 2 3 4 
            //}
            //Console.WriteLine("\n\n==================");

            ////to get first element in queue with delete it
            //int Dequeue = queue.Dequeue();
            //Console.WriteLine($"Dequeue Is {Dequeue}");
            //foreach (int i in queue)
            //{
            //    Console.Write("" + " " + i); //  2 3 4 
            //}


            #endregion




            #endregion


        }
    }
}
