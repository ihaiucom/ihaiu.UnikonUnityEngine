using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

namespace TestUnkonUnityEngeine
{
    class Program
    {
        static void Main(string[] args)
        {
            Scene scene = new Scene();
            GameObject go = new GameObject("Unit");
            MoveComponent move = go.AddComponent<MoveComponent>();
            move.MoveTo(new Vector3(100, 0, 0));

            Console.ReadLine();

            //while (true)
            //{
            //    try
            //    {
            //        Thread.Sleep(1);
            //        contex.Update();
            //        Game.EventSystem.Update();
            //    }
            //    catch (Exception e)
            //    {
            //        Log.Error(e);
            //    }
            //}
        }
    }
}
