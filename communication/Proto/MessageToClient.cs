// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MessageToClient.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Communication.Proto {

  /// <summary>Holder for reflection information generated from MessageToClient.proto</summary>
  public static partial class MessageToClientReflection {

    #region Descriptor
    /// <summary>File descriptor for MessageToClient.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MessageToClientReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVNZXNzYWdlVG9DbGllbnQucHJvdG8SCFByb3RvYnVmIvgCCgpHYW1lT2Jq",
            "ZWN0EhEKCVBvc2l0aW9uWBgBIAEoARIRCglQb3NpdGlvblkYAiABKAESJgoJ",
            "RGlyZWN0aW9uGAMgASgOMhMuUHJvdG9idWYuRGlyZWN0aW9uEiIKB09ialR5",
            "cGUYBCABKA4yES5Qcm90b2J1Zi5PYmpUeXBlEiYKCUJsb2NrVHlwZRgFIAEo",
            "DjITLlByb3RvYnVmLkJsb2NrVHlwZRIkCghEaXNoVHlwZRgGIAEoDjISLlBy",
            "b3RvYnVmLkRpc2hUeXBlEiQKCFRvb2xUeXBlGAcgASgOMhIuUHJvdG9idWYu",
            "VG9vbFR5cGUSKgoLVHJpZ2dlclR5cGUYCCABKA4yFS5Qcm90b2J1Zi5Ucmln",
            "Z2VyVHlwZRIQCghpc01vdmluZxgJIAEoCBIRCglTcGVha1RleHQYCiABKAkS",
            "DAoEdGVhbRgLIAEoBRISCgpTaWdodFJhbmdlGAwgASgFEhEKCU1vdmVTcGVl",
            "ZBgNIAEoASKuAgoPTWVzc2FnZVRvQ2xpZW50EkUKDkdhbWVPYmplY3RMaXN0",
            "GAEgAygLMi0uUHJvdG9idWYuTWVzc2FnZVRvQ2xpZW50LkdhbWVPYmplY3RM",
            "aXN0RW50cnkSIQoFVGFza3MYAiADKA4yEi5Qcm90b2J1Zi5EaXNoVHlwZRI1",
            "CgZTY29yZXMYAyADKAsyJS5Qcm90b2J1Zi5NZXNzYWdlVG9DbGllbnQuU2Nv",
            "cmVzRW50cnkaSwoTR2FtZU9iamVjdExpc3RFbnRyeRILCgNrZXkYASABKAMS",
            "IwoFdmFsdWUYAiABKAsyFC5Qcm90b2J1Zi5HYW1lT2JqZWN0OgI4ARotCgtT",
            "Y29yZXNFbnRyeRILCgNrZXkYASABKAUSDQoFdmFsdWUYAiABKAU6AjgBKlIK",
            "B09ialR5cGUSCgoGUGVvcGxlEAASCQoFQmxvY2sQARIICgREaXNoEAISCAoE",
            "VG9vbBADEgsKB1RyaWdnZXIQBBIPCgtPYmpUeXBlU2l6ZRAFKm0KCUJsb2Nr",
            "VHlwZRIICgRXYWxsEAASCQoFVGFibGUQARINCglGb29kUG9pbnQQAhIKCgZD",
            "b29rZXIQAxIOCgpSdWJiaXNoQmluEAQSDQoJVGFza1BvaW50EAUSEQoNQmxv",
            "Y2tUeXBlU2l6ZRAGKo8GCghEaXNoVHlwZRINCglEaXNoRW1wdHkQABIJCgVX",
            "aGVhdBABEggKBFJpY2UQAhIKCgZUb21hdG8QAxIHCgNFZ2cQBBIICgRNaWxr",
            "EAUSCQoFQXBwbGUQBhIKCgZCYW5hbmEQBxIMCghEYXJrUGx1bRAIEgwKCEhh",
            "d3Rob3JuEAkSDgoKU3RyYXdiZXJyeRAKEggKBEJlZWYQCxIICgRQb3JrEAwS",
            "DwoLQ2hpY2tlbk1lYXQQDRIKCgZQb3RhdG8QDhILCgdMZXR0dWNlEA8SCgoG",
            "QWdhcmljEBASEgoOTmVlZGxlTXVzaHJvb20QERILCgdDYWJiYWdlEBISDQoJ",
            "RGlzaFNpemUxEBMSCQoFRmxvdXIQFBIKCgZOb29kbGUQFRIJCgVCcmVhZBAW",
            "Eg4KCkNvb2tlZFJpY2UQFxILCgdLZXRjaHVwEBgSCQoFQ3JlYW0QGRISCg5U",
            "b21hdG9GcmllZEVnZxAaEhgKFFRvbWF0b0ZyaWVkRWdnTm9vZGxlEBsSDgoK",
            "QmVlZk5vb2RsZRAcEgwKCE92ZXJSaWNlEB0SEgoOWWVsbG93UGhlYXNhbnQQ",
            "HhIMCghCYXJiZWN1ZRAfEg8KC0ZyZW5jaEZyaWVzECASDQoJUGx1bUp1aWNl",
            "ECESDQoJSGFtYnVyZ2VyECISFgoSU3RyYXdiZXJyeUljZWNyZWFtECMSEgoO",
            "UG9wY29ybkNoaWNrZW4QJBISCg5BZ2FyaWNGcmllZEVnZxAlEggKBENha2UQ",
            "JhITCg9TdWdhckNvYXRlZEhhd3MQJxIOCgpGcnVpdFNhbGFkECgSDQoJU3Bp",
            "Y2VkUG90ECkSDgoKU3BpY2VkUG90MxAqEg4KClNwaWNlZFBvdDQQKxIOCgpT",
            "cGljZWRQb3Q1ECwSDgoKU3BpY2VkUG90NhAtEg4KClNwaWNlZFBvdDcQLhIO",
            "CgpTcGljZWRQb3Q4EC8SDQoJRGlzaFNpemUyEDASEgoOT3ZlckNvb2tlZERp",
            "c2gQMRIMCghEYXJrRGlzaBAyEg0KCURpc2hTaXplMxAzKowCCghUb29sVHlw",
            "ZRINCglUb29sRW1wdHkQABIOCgpUaWdlclNob2VzEAESDQoJU3BlZWRCdWZm",
            "EAISEAoMU3RyZW5ndGhCdWZmEAMSDQoJVGVsZVNjb3BlEAQSDQoJQ29uZGlt",
            "ZW50EAUSDgoKRmVydGlsaXplchAGEg8KC0JyZWFzdFBsYXRlEAcSDQoJU3Bh",
            "Y2VHYXRlEAgSEgoOV2F2ZUdsdWVCb3R0bGUQCRIMCghMYW5kTWluZRAKEgwK",
            "CFRyYXBUb29sEAsSDQoJRmxhc2hCb21iEAwSDwoLVGhyb3dIYW1tZXIQDRIH",
            "CgNCb3cQDhILCgdTdGVhbGVyEA8SDAoIVG9vbFNpemUQECphCgtUcmlnZ2Vy",
            "VHlwZRIMCghXYXZlR2x1ZRAAEggKBFRyYXAQARIICgRNaW5lEAISCAoEQm9t",
            "YhADEgkKBUFycm93EAQSCgoGSGFtbWVyEAUSDwoLVHJpZ2dlclNpemUQBip7",
            "CglEaXJlY3Rpb24SCQoFUmlnaHQQABILCgdSaWdodFVwEAESBgoCVXAQAhIK",
            "CgZMZWZ0VXAQAxIICgRMZWZ0EAQSDAoITGVmdERvd24QBRIICgREb3duEAYS",
            "DQoJUmlnaHREb3duEAcSEQoNRGlyZWN0aW9uU2l6ZRAIKmUKBlRhbGVudBII",
            "CgROb25lEAASCgoGUnVubmVyEAESDQoJU3Ryb25nTWFuEAISCAoEQ29vaxAD",
            "Eg4KClRlY2huaWNpYW4QBBIMCghMdWNreUJveRAFEg4KClRhbGVudFNpemUQ",
            "BkIWqgITQ29tbXVuaWNhdGlvbi5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Communication.Proto.ObjType), typeof(global::Communication.Proto.BlockType), typeof(global::Communication.Proto.DishType), typeof(global::Communication.Proto.ToolType), typeof(global::Communication.Proto.TriggerType), typeof(global::Communication.Proto.Direction), typeof(global::Communication.Proto.Talent), }, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Communication.Proto.GameObject), global::Communication.Proto.GameObject.Parser, new[]{ "PositionX", "PositionY", "Direction", "ObjType", "BlockType", "DishType", "ToolType", "TriggerType", "IsMoving", "SpeakText", "Team", "SightRange", "MoveSpeed" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Communication.Proto.MessageToClient), global::Communication.Proto.MessageToClient.Parser, new[]{ "GameObjectList", "Tasks", "Scores" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, null, })
          }));
    }
    #endregion

  }
  #region Enums
  /// <summary>
  ///可能出现在地图上的各种物品
  /// </summary>
  public enum ObjType {
    /// <summary>
    ///人
    /// </summary>
    [pbr::OriginalName("People")] People = 0,
    /// <summary>
    ///墙体
    /// </summary>
    [pbr::OriginalName("Block")] Block = 1,
    /// <summary>
    ///食材
    /// </summary>
    [pbr::OriginalName("Dish")] Dish = 2,
    /// <summary>
    ///道具
    /// </summary>
    [pbr::OriginalName("Tool")] Tool = 3,
    /// <summary>
    ///触发器
    /// </summary>
    [pbr::OriginalName("Trigger")] Trigger = 4,
    [pbr::OriginalName("ObjTypeSize")] Size = 5,
  }

  /// <summary>
  ///标1的物品扔出碰到会反弹，标0的会穿过去
  /// </summary>
  public enum BlockType {
    /// <summary>
    /// 1
    /// </summary>
    [pbr::OriginalName("Wall")] Wall = 0,
    /// <summary>
    /// 0
    /// </summary>
    [pbr::OriginalName("Table")] Table = 1,
    /// <summary>
    /// 1
    /// </summary>
    [pbr::OriginalName("FoodPoint")] FoodPoint = 2,
    /// <summary>
    /// 0
    /// </summary>
    [pbr::OriginalName("Cooker")] Cooker = 3,
    /// <summary>
    /// 0
    /// </summary>
    [pbr::OriginalName("RubbishBin")] RubbishBin = 4,
    /// <summary>
    /// 1
    /// </summary>
    [pbr::OriginalName("TaskPoint")] TaskPoint = 5,
    [pbr::OriginalName("BlockTypeSize")] Size = 6,
  }

  public enum DishType {
    [pbr::OriginalName("DishEmpty")] DishEmpty = 0,
    /// <summary>
    ///以下为食材
    /// </summary>
    [pbr::OriginalName("Wheat")] Wheat = 1,
    /// <summary>
    ///水稻
    /// </summary>
    [pbr::OriginalName("Rice")] Rice = 2,
    /// <summary>
    ///番茄
    /// </summary>
    [pbr::OriginalName("Tomato")] Tomato = 3,
    /// <summary>
    ///鸡蛋
    /// </summary>
    [pbr::OriginalName("Egg")] Egg = 4,
    /// <summary>
    ///牛奶
    /// </summary>
    [pbr::OriginalName("Milk")] Milk = 5,
    /// <summary>
    ///苹果
    /// </summary>
    [pbr::OriginalName("Apple")] Apple = 6,
    /// <summary>
    ///香蕉
    /// </summary>
    [pbr::OriginalName("Banana")] Banana = 7,
    /// <summary>
    ///乌梅
    /// </summary>
    [pbr::OriginalName("DarkPlum")] DarkPlum = 8,
    /// <summary>
    ///山楂
    /// </summary>
    [pbr::OriginalName("Hawthorn")] Hawthorn = 9,
    /// <summary>
    ///草莓
    /// </summary>
    [pbr::OriginalName("Strawberry")] Strawberry = 10,
    /// <summary>
    ///牛肉
    /// </summary>
    [pbr::OriginalName("Beef")] Beef = 11,
    /// <summary>
    ///猪肉
    /// </summary>
    [pbr::OriginalName("Pork")] Pork = 12,
    /// <summary>
    ///鸡肉
    /// </summary>
    [pbr::OriginalName("ChickenMeat")] ChickenMeat = 13,
    /// <summary>
    ///土豆
    /// </summary>
    [pbr::OriginalName("Potato")] Potato = 14,
    /// <summary>
    ///生菜
    /// </summary>
    [pbr::OriginalName("Lettuce")] Lettuce = 15,
    /// <summary>
    ///木耳
    /// </summary>
    [pbr::OriginalName("Agaric")] Agaric = 16,
    /// <summary>
    ///金针菇
    /// </summary>
    [pbr::OriginalName("NeedleMushroom")] NeedleMushroom = 17,
    /// <summary>
    ///包菜
    /// </summary>
    [pbr::OriginalName("Cabbage")] Cabbage = 18,
    [pbr::OriginalName("DishSize1")] DishSize1 = 19,
    /// <summary>
    ///以下为中间产物
    /// </summary>
    [pbr::OriginalName("Flour")] Flour = 20,
    /// <summary>
    ///面条
    /// </summary>
    [pbr::OriginalName("Noodle")] Noodle = 21,
    /// <summary>
    ///面包片
    /// </summary>
    [pbr::OriginalName("Bread")] Bread = 22,
    /// <summary>
    ///米饭
    /// </summary>
    [pbr::OriginalName("CookedRice")] CookedRice = 23,
    /// <summary>
    ///番茄酱
    /// </summary>
    [pbr::OriginalName("Ketchup")] Ketchup = 24,
    /// <summary>
    ///奶油
    /// </summary>
    [pbr::OriginalName("Cream")] Cream = 25,
    /// <summary>
    ///以下为菜品
    /// </summary>
    [pbr::OriginalName("TomatoFriedEgg")] TomatoFriedEgg = 26,
    /// <summary>
    ///西红柿鸡蛋面
    /// </summary>
    [pbr::OriginalName("TomatoFriedEggNoodle")] TomatoFriedEggNoodle = 27,
    /// <summary>
    ///清青牛拉
    /// </summary>
    [pbr::OriginalName("BeefNoodle")] BeefNoodle = 28,
    /// <summary>
    ///盖浇饭
    /// </summary>
    [pbr::OriginalName("OverRice")] OverRice = 29,
    /// <summary>
    ///黄焖鸡米饭
    /// </summary>
    [pbr::OriginalName("YellowPheasant")] YellowPheasant = 30,
    /// <summary>
    ///烤肉
    /// </summary>
    [pbr::OriginalName("Barbecue")] Barbecue = 31,
    /// <summary>
    ///薯条
    /// </summary>
    [pbr::OriginalName("FrenchFries")] FrenchFries = 32,
    /// <summary>
    ///酸梅汤
    /// </summary>
    [pbr::OriginalName("PlumJuice")] PlumJuice = 33,
    /// <summary>
    ///汉堡
    /// </summary>
    [pbr::OriginalName("Hamburger")] Hamburger = 34,
    /// <summary>
    ///草莓圣代
    /// </summary>
    [pbr::OriginalName("StrawberryIcecream")] StrawberryIcecream = 35,
    /// <summary>
    ///鸡米花
    /// </summary>
    [pbr::OriginalName("PopcornChicken")] PopcornChicken = 36,
    /// <summary>
    ///木耳炒蛋
    /// </summary>
    [pbr::OriginalName("AgaricFriedEgg")] AgaricFriedEgg = 37,
    /// <summary>
    ///蛋糕
    /// </summary>
    [pbr::OriginalName("Cake")] Cake = 38,
    /// <summary>
    ///冰糖葫芦
    /// </summary>
    [pbr::OriginalName("SugarCoatedHaws")] SugarCoatedHaws = 39,
    /// <summary>
    ///水果色拉
    /// </summary>
    [pbr::OriginalName("FruitSalad")] FruitSalad = 40,
    [pbr::OriginalName("SpicedPot")] SpicedPot = 41,
    [pbr::OriginalName("SpicedPot3")] SpicedPot3 = 42,
    [pbr::OriginalName("SpicedPot4")] SpicedPot4 = 43,
    [pbr::OriginalName("SpicedPot5")] SpicedPot5 = 44,
    [pbr::OriginalName("SpicedPot6")] SpicedPot6 = 45,
    [pbr::OriginalName("SpicedPot7")] SpicedPot7 = 46,
    /// <summary>
    ///香锅
    /// </summary>
    [pbr::OriginalName("SpicedPot8")] SpicedPot8 = 47,
    [pbr::OriginalName("DishSize2")] DishSize2 = 48,
    /// <summary>
    ///以下为垃圾
    /// </summary>
    [pbr::OriginalName("OverCookedDish")] OverCookedDish = 49,
    /// <summary>
    ///黑暗料理
    /// </summary>
    [pbr::OriginalName("DarkDish")] DarkDish = 50,
    [pbr::OriginalName("DishSize3")] DishSize3 = 51,
  }

  /// <summary>
  ///道具
  /// </summary>
  public enum ToolType {
    /// <summary>
    /// </summary>
    [pbr::OriginalName("ToolEmpty")] ToolEmpty = 0,
    /// <summary>
    ///虎头鞋，穿上加速，扔掉恢复原速
    /// </summary>
    [pbr::OriginalName("TigerShoes")] TigerShoes = 1,
    /// <summary>
    ///加速，一定时间内加速
    /// </summary>
    [pbr::OriginalName("SpeedBuff")] SpeedBuff = 2,
    /// <summary>
    ///加力量，一定时间内增加扔物品的距离
    /// </summary>
    [pbr::OriginalName("StrengthBuff")] StrengthBuff = 3,
    /// <summary>
    ///望远镜，增加视野范围
    /// </summary>
    [pbr::OriginalName("TeleScope")] TeleScope = 4,
    /// <summary>
    ///调料，提交香锅时专用
    /// </summary>
    [pbr::OriginalName("Condiment")] Condiment = 5,
    /// <summary>
    ///肥料，加速做菜
    /// </summary>
    [pbr::OriginalName("Fertilizer")] Fertilizer = 6,
    /// <summary>
    ///护心镜，防止各种攻击性道具
    /// </summary>
    [pbr::OriginalName("BreastPlate")] BreastPlate = 7,
    /// <summary>
    ///传送门，瞬间传送到指定地点
    /// </summary>
    [pbr::OriginalName("SpaceGate")] SpaceGate = 8,
    /// <summary>
    /// Eye = 9;
    /// </summary>
    [pbr::OriginalName("WaveGlueBottle")] WaveGlueBottle = 9,
    /// <summary>
    ///放置地雷
    /// </summary>
    [pbr::OriginalName("LandMine")] LandMine = 10,
    /// <summary>
    ///放置陷阱
    /// </summary>
    [pbr::OriginalName("TrapTool")] TrapTool = 11,
    /// <summary>
    ///防止闪光炸弹
    /// </summary>
    [pbr::OriginalName("FlashBomb")] FlashBomb = 12,
    /// <summary>
    ///扔锤子
    /// </summary>
    [pbr::OriginalName("ThrowHammer")] ThrowHammer = 13,
    /// <summary>
    ///弓箭
    /// </summary>
    [pbr::OriginalName("Bow")] Bow = 14,
    /// <summary>
    ///偷东西，可以偷食材
    /// </summary>
    [pbr::OriginalName("Stealer")] Stealer = 15,
    [pbr::OriginalName("ToolSize")] ToolSize = 16,
  }

  public enum TriggerType {
    /// <summary>
    ///滔牌胶水，踩上后会减速，过一段时间自行消失
    /// </summary>
    [pbr::OriginalName("WaveGlue")] WaveGlue = 0,
    /// <summary>
    ///陷阱，踩上后有一段时间不能动弹
    /// </summary>
    [pbr::OriginalName("Trap")] Trap = 1,
    /// <summary>
    ///地雷，踩上后减分数并眩晕一段时间
    /// </summary>
    [pbr::OriginalName("Mine")] Mine = 2,
    /// <summary>
    ///炸弹，踩上后眩晕一段时间，并掉落身上的食材和道具
    /// </summary>
    [pbr::OriginalName("Bomb")] Bomb = 3,
    /// <summary>
    ///箭，被射中后扣一定的分数并眩晕一段时间
    /// </summary>
    [pbr::OriginalName("Arrow")] Arrow = 4,
    /// <summary>
    ///锤子，被砸中后眩晕一段时间并掉落身上的食材和道具
    /// </summary>
    [pbr::OriginalName("Hammer")] Hammer = 5,
    [pbr::OriginalName("TriggerSize")] TriggerSize = 6,
  }

  public enum Direction {
    [pbr::OriginalName("Right")] Right = 0,
    [pbr::OriginalName("RightUp")] RightUp = 1,
    [pbr::OriginalName("Up")] Up = 2,
    [pbr::OriginalName("LeftUp")] LeftUp = 3,
    [pbr::OriginalName("Left")] Left = 4,
    [pbr::OriginalName("LeftDown")] LeftDown = 5,
    [pbr::OriginalName("Down")] Down = 6,
    [pbr::OriginalName("RightDown")] RightDown = 7,
    [pbr::OriginalName("DirectionSize")] Size = 8,
  }

  public enum Talent {
    [pbr::OriginalName("None")] None = 0,
    /// <summary>
    /// 跑步加速
    /// </summary>
    [pbr::OriginalName("Runner")] Runner = 1,
    /// <summary>
    ///扔东西距离变远，扔锤子和射箭伤害更大
    /// </summary>
    [pbr::OriginalName("StrongMan")] StrongMan = 2,
    /// <summary>
    ///制作食材获得分数有一定加成
    /// </summary>
    [pbr::OriginalName("Cook")] Cook = 3,
    /// <summary>
    ///防止地雷、陷阱、炸弹、使用传送门有一定加成
    /// </summary>
    [pbr::OriginalName("Technician")] Technician = 4,
    /// <summary>
    ///每隔一段时间在手上生成一个道具，若手上已有道具则在身边的地面生成
    /// </summary>
    [pbr::OriginalName("LuckyBoy")] LuckyBoy = 5,
    /// <summary>
    /// DrunkMan
    /// </summary>
    [pbr::OriginalName("TalentSize")] Size = 6,
  }

  #endregion

  #region Messages
  public sealed partial class GameObject : pb::IMessage<GameObject> {
    private static readonly pb::MessageParser<GameObject> _parser = new pb::MessageParser<GameObject>(() => new GameObject());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GameObject> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Communication.Proto.MessageToClientReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GameObject() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GameObject(GameObject other) : this() {
      positionX_ = other.positionX_;
      positionY_ = other.positionY_;
      direction_ = other.direction_;
      objType_ = other.objType_;
      blockType_ = other.blockType_;
      dishType_ = other.dishType_;
      toolType_ = other.toolType_;
      triggerType_ = other.triggerType_;
      isMoving_ = other.isMoving_;
      speakText_ = other.speakText_;
      team_ = other.team_;
      sightRange_ = other.sightRange_;
      moveSpeed_ = other.moveSpeed_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GameObject Clone() {
      return new GameObject(this);
    }

    /// <summary>Field number for the "PositionX" field.</summary>
    public const int PositionXFieldNumber = 1;
    private double positionX_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double PositionX {
      get { return positionX_; }
      set {
        positionX_ = value;
      }
    }

    /// <summary>Field number for the "PositionY" field.</summary>
    public const int PositionYFieldNumber = 2;
    private double positionY_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double PositionY {
      get { return positionY_; }
      set {
        positionY_ = value;
      }
    }

    /// <summary>Field number for the "Direction" field.</summary>
    public const int DirectionFieldNumber = 3;
    private global::Communication.Proto.Direction direction_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Communication.Proto.Direction Direction {
      get { return direction_; }
      set {
        direction_ = value;
      }
    }

    /// <summary>Field number for the "ObjType" field.</summary>
    public const int ObjTypeFieldNumber = 4;
    private global::Communication.Proto.ObjType objType_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Communication.Proto.ObjType ObjType {
      get { return objType_; }
      set {
        objType_ = value;
      }
    }

    /// <summary>Field number for the "BlockType" field.</summary>
    public const int BlockTypeFieldNumber = 5;
    private global::Communication.Proto.BlockType blockType_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Communication.Proto.BlockType BlockType {
      get { return blockType_; }
      set {
        blockType_ = value;
      }
    }

    /// <summary>Field number for the "DishType" field.</summary>
    public const int DishTypeFieldNumber = 6;
    private global::Communication.Proto.DishType dishType_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Communication.Proto.DishType DishType {
      get { return dishType_; }
      set {
        dishType_ = value;
      }
    }

    /// <summary>Field number for the "ToolType" field.</summary>
    public const int ToolTypeFieldNumber = 7;
    private global::Communication.Proto.ToolType toolType_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Communication.Proto.ToolType ToolType {
      get { return toolType_; }
      set {
        toolType_ = value;
      }
    }

    /// <summary>Field number for the "TriggerType" field.</summary>
    public const int TriggerTypeFieldNumber = 8;
    private global::Communication.Proto.TriggerType triggerType_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Communication.Proto.TriggerType TriggerType {
      get { return triggerType_; }
      set {
        triggerType_ = value;
      }
    }

    /// <summary>Field number for the "isMoving" field.</summary>
    public const int IsMovingFieldNumber = 9;
    private bool isMoving_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsMoving {
      get { return isMoving_; }
      set {
        isMoving_ = value;
      }
    }

    /// <summary>Field number for the "SpeakText" field.</summary>
    public const int SpeakTextFieldNumber = 10;
    private string speakText_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SpeakText {
      get { return speakText_; }
      set {
        speakText_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "team" field.</summary>
    public const int TeamFieldNumber = 11;
    private int team_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Team {
      get { return team_; }
      set {
        team_ = value;
      }
    }

    /// <summary>Field number for the "SightRange" field.</summary>
    public const int SightRangeFieldNumber = 12;
    private int sightRange_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int SightRange {
      get { return sightRange_; }
      set {
        sightRange_ = value;
      }
    }

    /// <summary>Field number for the "MoveSpeed" field.</summary>
    public const int MoveSpeedFieldNumber = 13;
    private double moveSpeed_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double MoveSpeed {
      get { return moveSpeed_; }
      set {
        moveSpeed_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GameObject);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GameObject other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(PositionX, other.PositionX)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(PositionY, other.PositionY)) return false;
      if (Direction != other.Direction) return false;
      if (ObjType != other.ObjType) return false;
      if (BlockType != other.BlockType) return false;
      if (DishType != other.DishType) return false;
      if (ToolType != other.ToolType) return false;
      if (TriggerType != other.TriggerType) return false;
      if (IsMoving != other.IsMoving) return false;
      if (SpeakText != other.SpeakText) return false;
      if (Team != other.Team) return false;
      if (SightRange != other.SightRange) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(MoveSpeed, other.MoveSpeed)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (PositionX != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(PositionX);
      if (PositionY != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(PositionY);
      if (Direction != 0) hash ^= Direction.GetHashCode();
      if (ObjType != 0) hash ^= ObjType.GetHashCode();
      if (BlockType != 0) hash ^= BlockType.GetHashCode();
      if (DishType != 0) hash ^= DishType.GetHashCode();
      if (ToolType != 0) hash ^= ToolType.GetHashCode();
      if (TriggerType != 0) hash ^= TriggerType.GetHashCode();
      if (IsMoving != false) hash ^= IsMoving.GetHashCode();
      if (SpeakText.Length != 0) hash ^= SpeakText.GetHashCode();
      if (Team != 0) hash ^= Team.GetHashCode();
      if (SightRange != 0) hash ^= SightRange.GetHashCode();
      if (MoveSpeed != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(MoveSpeed);
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (PositionX != 0D) {
        output.WriteRawTag(9);
        output.WriteDouble(PositionX);
      }
      if (PositionY != 0D) {
        output.WriteRawTag(17);
        output.WriteDouble(PositionY);
      }
      if (Direction != 0) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Direction);
      }
      if (ObjType != 0) {
        output.WriteRawTag(32);
        output.WriteEnum((int) ObjType);
      }
      if (BlockType != 0) {
        output.WriteRawTag(40);
        output.WriteEnum((int) BlockType);
      }
      if (DishType != 0) {
        output.WriteRawTag(48);
        output.WriteEnum((int) DishType);
      }
      if (ToolType != 0) {
        output.WriteRawTag(56);
        output.WriteEnum((int) ToolType);
      }
      if (TriggerType != 0) {
        output.WriteRawTag(64);
        output.WriteEnum((int) TriggerType);
      }
      if (IsMoving != false) {
        output.WriteRawTag(72);
        output.WriteBool(IsMoving);
      }
      if (SpeakText.Length != 0) {
        output.WriteRawTag(82);
        output.WriteString(SpeakText);
      }
      if (Team != 0) {
        output.WriteRawTag(88);
        output.WriteInt32(Team);
      }
      if (SightRange != 0) {
        output.WriteRawTag(96);
        output.WriteInt32(SightRange);
      }
      if (MoveSpeed != 0D) {
        output.WriteRawTag(105);
        output.WriteDouble(MoveSpeed);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (PositionX != 0D) {
        size += 1 + 8;
      }
      if (PositionY != 0D) {
        size += 1 + 8;
      }
      if (Direction != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Direction);
      }
      if (ObjType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ObjType);
      }
      if (BlockType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) BlockType);
      }
      if (DishType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) DishType);
      }
      if (ToolType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ToolType);
      }
      if (TriggerType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) TriggerType);
      }
      if (IsMoving != false) {
        size += 1 + 1;
      }
      if (SpeakText.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SpeakText);
      }
      if (Team != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Team);
      }
      if (SightRange != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(SightRange);
      }
      if (MoveSpeed != 0D) {
        size += 1 + 8;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GameObject other) {
      if (other == null) {
        return;
      }
      if (other.PositionX != 0D) {
        PositionX = other.PositionX;
      }
      if (other.PositionY != 0D) {
        PositionY = other.PositionY;
      }
      if (other.Direction != 0) {
        Direction = other.Direction;
      }
      if (other.ObjType != 0) {
        ObjType = other.ObjType;
      }
      if (other.BlockType != 0) {
        BlockType = other.BlockType;
      }
      if (other.DishType != 0) {
        DishType = other.DishType;
      }
      if (other.ToolType != 0) {
        ToolType = other.ToolType;
      }
      if (other.TriggerType != 0) {
        TriggerType = other.TriggerType;
      }
      if (other.IsMoving != false) {
        IsMoving = other.IsMoving;
      }
      if (other.SpeakText.Length != 0) {
        SpeakText = other.SpeakText;
      }
      if (other.Team != 0) {
        Team = other.Team;
      }
      if (other.SightRange != 0) {
        SightRange = other.SightRange;
      }
      if (other.MoveSpeed != 0D) {
        MoveSpeed = other.MoveSpeed;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 9: {
            PositionX = input.ReadDouble();
            break;
          }
          case 17: {
            PositionY = input.ReadDouble();
            break;
          }
          case 24: {
            Direction = (global::Communication.Proto.Direction) input.ReadEnum();
            break;
          }
          case 32: {
            ObjType = (global::Communication.Proto.ObjType) input.ReadEnum();
            break;
          }
          case 40: {
            BlockType = (global::Communication.Proto.BlockType) input.ReadEnum();
            break;
          }
          case 48: {
            DishType = (global::Communication.Proto.DishType) input.ReadEnum();
            break;
          }
          case 56: {
            ToolType = (global::Communication.Proto.ToolType) input.ReadEnum();
            break;
          }
          case 64: {
            TriggerType = (global::Communication.Proto.TriggerType) input.ReadEnum();
            break;
          }
          case 72: {
            IsMoving = input.ReadBool();
            break;
          }
          case 82: {
            SpeakText = input.ReadString();
            break;
          }
          case 88: {
            Team = input.ReadInt32();
            break;
          }
          case 96: {
            SightRange = input.ReadInt32();
            break;
          }
          case 105: {
            MoveSpeed = input.ReadDouble();
            break;
          }
        }
      }
    }

  }

  public sealed partial class MessageToClient : pb::IMessage<MessageToClient> {
    private static readonly pb::MessageParser<MessageToClient> _parser = new pb::MessageParser<MessageToClient>(() => new MessageToClient());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MessageToClient> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Communication.Proto.MessageToClientReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MessageToClient() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MessageToClient(MessageToClient other) : this() {
      gameObjectList_ = other.gameObjectList_.Clone();
      tasks_ = other.tasks_.Clone();
      scores_ = other.scores_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MessageToClient Clone() {
      return new MessageToClient(this);
    }

    /// <summary>Field number for the "GameObjectList" field.</summary>
    public const int GameObjectListFieldNumber = 1;
    private static readonly pbc::MapField<long, global::Communication.Proto.GameObject>.Codec _map_gameObjectList_codec
        = new pbc::MapField<long, global::Communication.Proto.GameObject>.Codec(pb::FieldCodec.ForInt64(8), pb::FieldCodec.ForMessage(18, global::Communication.Proto.GameObject.Parser), 10);
    private readonly pbc::MapField<long, global::Communication.Proto.GameObject> gameObjectList_ = new pbc::MapField<long, global::Communication.Proto.GameObject>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<long, global::Communication.Proto.GameObject> GameObjectList {
      get { return gameObjectList_; }
    }

    /// <summary>Field number for the "Tasks" field.</summary>
    public const int TasksFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Communication.Proto.DishType> _repeated_tasks_codec
        = pb::FieldCodec.ForEnum(18, x => (int) x, x => (global::Communication.Proto.DishType) x);
    private readonly pbc::RepeatedField<global::Communication.Proto.DishType> tasks_ = new pbc::RepeatedField<global::Communication.Proto.DishType>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Communication.Proto.DishType> Tasks {
      get { return tasks_; }
    }

    /// <summary>Field number for the "Scores" field.</summary>
    public const int ScoresFieldNumber = 3;
    private static readonly pbc::MapField<int, int>.Codec _map_scores_codec
        = new pbc::MapField<int, int>.Codec(pb::FieldCodec.ForInt32(8), pb::FieldCodec.ForInt32(16), 26);
    private readonly pbc::MapField<int, int> scores_ = new pbc::MapField<int, int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<int, int> Scores {
      get { return scores_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MessageToClient);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MessageToClient other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!GameObjectList.Equals(other.GameObjectList)) return false;
      if(!tasks_.Equals(other.tasks_)) return false;
      if (!Scores.Equals(other.Scores)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= GameObjectList.GetHashCode();
      hash ^= tasks_.GetHashCode();
      hash ^= Scores.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      gameObjectList_.WriteTo(output, _map_gameObjectList_codec);
      tasks_.WriteTo(output, _repeated_tasks_codec);
      scores_.WriteTo(output, _map_scores_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += gameObjectList_.CalculateSize(_map_gameObjectList_codec);
      size += tasks_.CalculateSize(_repeated_tasks_codec);
      size += scores_.CalculateSize(_map_scores_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MessageToClient other) {
      if (other == null) {
        return;
      }
      gameObjectList_.Add(other.gameObjectList_);
      tasks_.Add(other.tasks_);
      scores_.Add(other.scores_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            gameObjectList_.AddEntriesFrom(input, _map_gameObjectList_codec);
            break;
          }
          case 18:
          case 16: {
            tasks_.AddEntriesFrom(input, _repeated_tasks_codec);
            break;
          }
          case 26: {
            scores_.AddEntriesFrom(input, _map_scores_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
