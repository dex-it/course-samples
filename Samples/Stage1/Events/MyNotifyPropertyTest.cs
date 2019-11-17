//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Runtime.CompilerServices;
//using System.Security.Claims;
//using System.Threading;
//using NUnit.Framework;
//using Stage1.Annotations;
//
//namespace Stage1
//{
//    //реализовать очередь которая генерирует событие
//    //когда кол-во объектов в ней превышает n и событие когда становится пустой   
//
//    [TestFixture]
//     public class MyQuene<T>
//     {
//         private event EventHandler Full;
//         private event EventHandler Empty;
// 
//         private Queue<T> _queue;
// 
//         public int MaxCount { get; set; }
// 
//         public MyQuene()
//         {
//             _queue = new Queue<T>();
//         }
// 
//         public void Add(T item)
//         {
//             try
//             {
//                 if (_queue.Count == MaxCount)
//                 {
//                     Full?.Invoke(this, EventArgs.Empty);
//                     return;
//                 }
// 
//                 _queue.Enqueue(item);
//             }
//             catch (Exception e)
//             {
//                 Console.WriteLine(e);
//                 throw;
//             }
//         }
// 
//         public bool Dequeue()
//         {
//             _queue.Dequeue();
//             if (_queue.Count == 0)
//             {
//                 Empty?.Invoke(this, EventArgs.Empty);
//             }
// 
//             return true;
//         }
//     }
// }