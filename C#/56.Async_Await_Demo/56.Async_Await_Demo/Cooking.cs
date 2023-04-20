﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _56.Async_Await_Demo
{
    public class Cooking
    {
        /// <summary>
        ///  동기 방식의 밥 만들기 메서드
        /// </summary>
        /// <returns>밥</returns>
        public Rice MakeRice()
        {
            Console.WriteLine("밥 생성중...");
            Thread.Sleep(3001);
            return new Rice();
        }

        /// <summary>
        /// 비동기 방식의 밥 만들기 메서드
        /// </summary>
        /// <returns>밥</returns>
        public async Task<Rice> MakeRiceAsync()
        {
            Console.WriteLine("밥 생성중...");
            Thread.Sleep(3001);
            return new Rice();
        }

        /// <summary>
        ///  동기 방식의 국 만들기 메서드
        /// </summary>
        /// <returns>국</returns>
        public Soup MakeSoup()
        {
            Console.WriteLine("국 생성중...");
            Thread.Sleep(3001);
            return new Soup();
        }

        /// <summary>
        /// 비동기 방식의 국 만들기 메서드
        /// </summary>
        /// <returns>국</returns>
        public async Task<Soup> MakeSoupAsync()
        {
            Console.WriteLine("국 생성중...");
            await Task.Run(() => Task.Delay(3001));
            return new Soup();
        }

        /// <summary>
        ///  동기 방식의 달걀 만들기 메서드
        /// </summary>
        /// <returns>달걀</returns>
        public Egg MakeEgg()
        {
            Console.WriteLine("달걀 생성중...");
            Thread.Sleep(3001);
            return new Egg();
        }

        /// <summary>
        /// 비동기 방식의 달걀 만들기 메서드
        /// </summary>
        /// <returns>달걀</returns>
        public async Task<Egg> MakeEggAsync()
        {
            Console.WriteLine("달걀 생성중...");
            await Task.Delay(TimeSpan.FromMilliseconds(3001));
            return await Task.FromResult<Egg>(new Egg());
        }

       
    }

    public class Rice
    {
    }

    public class Soup
    {
    }

    public class Egg
    {
    }
}
