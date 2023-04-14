/**************************************************************************
* Created 2021/8/12 15:34:34
* Description: HeroJourney.英雄之旅.解构旅程
****************************************************************************/

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using HeroJourney.英雄之旅;

namespace HeroJourney.StoryLine
{
    //class PlotStructure
    //{
    //    /// <summary>
    //    /// HeroJourney.英雄之旅.解构旅程.Run();
    //    /// </summary>
    //    public static void Run()
    //    {
    //        Console.WriteLine("\n//解构旅程");
    //        Console.WriteLine("-------------------------");
    //        App();
    //        Console.WriteLine();
    //    }

    //    static void App()
    //    {
    //    }
    //}
}

namespace HeroJourney
{

    //接口只有一个方法才可利用写作模板
    interface IJourney
    {
        void Process();
        //void Do(string t);
        void Done(Person p);
    }

    //为了简化代码定义了一个通用类
   class Journey
    {
        public string Abstract { get; set; }
        public virtual void Process()
        {
            Console.WriteLine($"{Abstract}\n"); //Console.WriteLine($"{this.GetType().Name}");
        }
        //public void Do(string t)
        //{
        //    Console.WriteLine($"{t}和整个存在在一起\n"); //Console.WriteLine($"{this.GetType().Name}");
        //}

        public void Done(Person p)
        {
            Console.WriteLine($"{p.Name}和整个存在在一起\n"); //Console.WriteLine($"{this.GetType().Name}");
        }
    }
}

namespace HeroJourney
{

    //写作模板读取的类
    class 正常世界 : Journey, IJourney
    {
        public 正常世界()
        {
            Abstract = Blackboard.正常世界;
        }

    }
    class 冒险召唤 : Journey, IJourney
    {
        public 冒险召唤()
        {
            Abstract = Blackboard.冒险召唤;
        }
    }
    class 拒绝召唤 : Journey, IJourney
    {
        public 拒绝召唤()
        {
            Abstract = Blackboard.拒绝召唤;
        }
    }
    class 逢遇智者 : Journey, IJourney
    {
        public 逢遇智者()
        {
            Abstract = Blackboard.逢遇智者;
        }
    }
    class 穿越启程 : Journey, IJourney
    {
        public 穿越启程()
        {
            Abstract = Blackboard.穿越启程;
        }
    }
    class 敌友考验 : Journey, IJourney
    {
        public 敌友考验()
        {
            Abstract = Blackboard.敌友考验;
        }
    }
    class 深入虎穴 : Journey, IJourney
    {
        public 深入虎穴()
        {
            Abstract = Blackboard.深入虎穴;
        }
    }
    class 绝望境地 : Journey, IJourney
    {
        public 绝望境地()
        {
            Abstract = Blackboard.绝望境地;
        }
    }
    class 获取殊荣 : Journey, IJourney
    {
        public 获取殊荣()
        {
            Abstract = Blackboard.获取殊荣;
        }
    }
    class 回归之路 : Journey, IJourney
    {
        public 回归之路()
        {
            Abstract = Blackboard.回归之路;
        }
    }
    class 浴火重生 : Journey, IJourney
    {
        public 浴火重生()
        {
            Abstract = Blackboard.浴火重生;
        }
    }
    class 凯旋而归 : Journey, IJourney
    {
        public 凯旋而归()
        {
            Abstract = Blackboard.凯旋而归;
        }
        public override void Process()
        {
            Console.WriteLine($"!!{Abstract}\n"); //Console.WriteLine($"{this.GetType().Name}");
        }
        public new void Do(string t)
        {
            Console.WriteLine($"{t}放下即得解脱:柔情似水的女人\n"); //Console.WriteLine($"{this.GetType().Name}");
        }

        public new void Done(Person p)
        {
            Console.WriteLine($"{p.Name}放下即得自在\n"); //Console.WriteLine($"{this.GetType().Name}");
        }
    }

    class Person 
    {
        public string Name { get; set; }
        public Person()
        {
            Name = "我是个大英雄了！";
        }
        public void Act()
        {
            Console.WriteLine("大英雄有所为。");
        }

        public void Process()
        {
            Console.WriteLine("大英雄有所为。");
        }

        public void Do(string t)
        {
            ;
        }

        public void Done(Person p)
        {
            ;
        }
    }
}