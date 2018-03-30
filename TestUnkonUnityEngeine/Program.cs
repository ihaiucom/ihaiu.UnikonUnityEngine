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
            MainThreadRunner.Install();

            GameObject go = new GameObject("Unit");
            MoveComponent move = go.AddComponent<MoveComponent>();
            move.MoveTo(new Vector3(100, 0, 0));

            while (true)
            {
                try
                {
                    Thread.Sleep(100);
                    MainThreadRunner.Update();
                    //Game.EventSystem.Update();
                    SceneManager.Update();
                }
                catch (Exception e)
                {
                    Loger.LogError(e);
                }
            }
        }

    }
}
