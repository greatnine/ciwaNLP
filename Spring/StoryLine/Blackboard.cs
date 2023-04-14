using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroJourney.英雄之旅
{
    class Blackboard
    {
        public static string 正常世界 { get; set; } =
            $"【{nameof(正常世界)}】" +
            $"这是我们的英雄主角生活的正常世界，平淡，例行常规。我们的英雄在这里舒服，安全。" +
            "但是，心里总会冒出一个奇怪的想法，这个世界有什么地方不对，英雄内心深处有个空缺。";

        public static string 冒险召唤 { get; set; } =
            $"【{nameof(冒险召唤)}】" +
            $"一件事发生，一扇门打开，一人的出现打乱了主人公规律的生活，呼唤他开始一场冒险。";

        public static string 拒绝召唤 { get; set; } =
            $"【{nameof(拒绝召唤)}】" +
            $"和我们每个人一样，主人公的第一反应是拒绝冒险，拒绝变化，待在他熟悉舒适的环境里。";

        public static string 逢遇智者 { get; set; } =
            $"【{nameof(逢遇智者)}】" +
            $"在主人公犹豫不决的时候，一个智者或者导师出现，帮助他下定决心，开始了冒险旅程。";

        public static string 穿越启程 { get; set; } =
            $"【{nameof(穿越启程)}】" +
            $"我们的主人公离开了熟悉的家园和生活，跨越了一个门槛，进入一个新的世界。";

        public static string 敌友考验 { get; set; } =
            $"【{nameof(敌友考验)}】" +
            $"在新的，陌生的世界里，主人公受到了各种考验，遇见了日后共同战斗的伙伴，当然难免会遇到他的敌人。";

        public static string 深入虎穴 { get; set; } =
            $"【{nameof(深入虎穴)}】" +
            $"突发事件让故事突然转折，让主人公进入黑暗的洞穴，走上了一条不归路。";

        public static string 绝望境地 { get; set; } =
            $"【{nameof(绝望境地)}】" +
            $"英雄处境的最低谷。强大的敌人完全占据上风，所有的希望都已丧失。英雄处于绝望的境地。" +
            "但是同时，主人公的英雄本色开始显示出来，他从一个有缺陷的人变成 一个真正的英雄。";

        public static string 获取殊荣 { get; set; } =
            $"【{nameof(获取殊荣)}】" +
            $"英雄因为他的勇敢，高贵的行为受到了奖励。他也在困难磨炼中获得了珍贵的经验。";

        public static string 回归之路 { get; set; } =
            $"【{nameof(回归之路)}】" +
            $"主人公出征\\奋战后终于走上了回家(归属)的路。同样是家，大家却看到了主人公前后的不同。";

        public static string 浴火重生 { get; set; } =
            $"【{nameof(浴火重生)}】" +
            $"主人公涅槃重生，他现在是个改变了的人，变得更好的人，一个真正的英雄。";

        public static string 凯旋而归 { get; set; } =
            $"【{nameof(凯旋而归)}】" +
            $"英雄完成了他的使命，得到了美人，大家从此过上幸福的生活。";
    }
}

/*

<#
var list = new List<string>()
{
"正常世界",
"冒险召唤",
"拒绝召唤",
"逢遇智者",
"穿越启程",
"敌友考验",
"深入虎穴",
"绝望境地",
"获取殊荣",
"回家之路",
"浴火重生",
"凯旋而归", };

foreach (var item in list)
{
public string item { get; set; }
}#>

*/

/*
正常世界
冒险召唤
拒绝召唤
逢遇智者
穿越启程
敌友考验
深入虎穴
绝望境地
获取殊荣
回家之路
浴火重生
凯旋而归
*/